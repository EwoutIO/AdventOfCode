﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoC.Helpers.IntComputer
{
    public class Computer
    {
        public List<State> States { get; private set; } = new List<State>();
        public List<long> Outputs { get; private set; } = new List<long>();
        public bool Finished { get; set; } = false;

        private Queue<long> inputQueue;

        private long[] memory = Array.Empty<long>();

        private long instructionPointer = 0;

        private long relativeBase = 0;

        public Computer(string program) : this(program, new List<long>()) { }
        public Computer(string program, long value) : this(program, new List<long>() { value }) { }
        public Computer(string program, int[] values) : this(program, values.Select(v => (long)v)) { }
        public Computer(string program, IEnumerable<long> inputs)
        {
            var parsedProgram = ParseProgram(program);
            memory = new long[8192];
            parsedProgram.CopyTo(memory, 0);

            inputQueue = new Queue<long>(inputs);
        }

        public void SetAddress(long address, long value) => memory[address] = value;
        public void ClearOutputs() => Outputs.Clear();

        public (List<State> states, List<long> outputs) Resume(int input) => Resume((long)input);
        public (List<State> states, List<long> outputs) Resume(long input)
        {
            inputQueue.Enqueue(input);
            return Run();
        }

        public (List<State> states, List<long> outputs) Resume(int[] inputs)
        {
            foreach (var input in inputs)
            {
                inputQueue.Enqueue(input);
            }

            return Run();
        }

        public (List<State> states, List<long> outputs) Run()
        {
            while (instructionPointer < memory.Length)
            {
                var resp = Next(memory, instructionPointer, relativeBase);

                if (resp.Halt || resp.BreakProcess)
                {
                    Finished = resp.Halt;
                    break;
                }

                if (resp.Value != null)
                {
                    Outputs.Add(resp.Value.Value);
                }

                memory = resp.Memory;
                instructionPointer = resp.NextInstructionPointer;
                relativeBase = resp.NextRelativeBase;
            }

            // return last state.
            return (States, Outputs);
        }

        private Response Next(long[] memory, long ip, long rb)
        {
            var instruction = new Instruction(memory, ip, rb);

            if (instruction.OpCode == OpCode.SET && inputQueue.Any())
            {
                instruction.Input = inputQueue.Dequeue();
            }
            else if (instruction.OpCode == OpCode.SET)
            {
                // break process, return latest output, wait for new input
                return new Response(memory, ip, rb, false, null, true);
            }

            var response =  Operations.ExecuteOperation(instruction);
            States.Add(new State(response.Memory, instruction.OpCode, instruction.InstructionPointer, instruction.RelativeBase, instruction.Instr));
            return response;
        }

        private static long[] ParseProgram(string input) => input.Split(',').Select(i => long.Parse(i)).ToArray();
    }
}
