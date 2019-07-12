using System;
using Xunit;

namespace test
{
    public class MarsRoverTest
    {

        static Position AnyPosition = new Position(1, 2);

        // input 
        /// initialpos: [x, y]
        /// initialdirection: 'E' | 'N' | 'W' | 'S'
        /// commands list "fbrl"

        // output 
        /// currentpos: [x1, y1]
        /// currentdir: 'N' 
        /// OR BLOCKED

        [Fact]
        public void InAbsenceOfCommandsTheCurrentStateIsTheInitialState()
        {
            var initialDirection = Direction.North;
            var initialPosition = AnyPosition;
            var initialRover = new Rover(initialDirection, initialPosition);

            const string none = "";
            var rover = new Commands(none).MoveRover(initialRover);

            Assert.Equal(initialDirection, rover.Direction);
            Assert.Equal(initialPosition, rover.Position);
        }

        [Fact]
        public void MoveOneStepForward()
        {
            var initialRover = new Rover(Direction.North, new Position(1, 2));

            var commands = "f";
            var rover = new Commands(commands).MoveRover(initialRover);

            Assert.Equal(Direction.North, rover.Direction);
            Assert.Equal(new Position(1, 3), rover.Position);
        }

        [Fact]
        public void MoveTwoStepsForward()
        {
            var initialRover = new Rover(Direction.North, new Position(1, 2));

            var commands = "ff";
            var rover = new Commands(commands).MoveRover(initialRover);

            Assert.Equal(Direction.North, rover.Direction);
            Assert.Equal(new Position(1, 4), rover.Position);
        }

        // [Fact(Skip="not yet")]
        // public void MoveOneStepsForwardAndOneStepBack()
        // {
        //     var initialDirection = Direction.North;
        //     var initialPosition = AnyPosition;
        //     var initialRover = new Rover(initialDirection, initialPosition);

        //     var commands = "fb";

        //     Position firstPositin = initialPosition.IncY();
        //     Position currentPosition = firstPositin.DecY();

        //     var rover = new Rover(initialDirection, currentPosition);

        //     Assert.Equal(initialDirection, rover.Direction);
        //     Assert.Equal(initialPosition, rover.Position);
        //     // "Problem" now is that we are not progressing the existing code.
        //     // Maybe we extracted too early.
        // }

    }

    public class Rover
    {
        public Rover(Direction direction, Position position)
        {
            Direction = direction;
            Position = position;
        }

        public Direction Direction { get; private set; }
        public Position Position { get; private set; }
    }

    public class Commands
    {
        private readonly string commands;

        public Commands(string commands)
        {
            this.commands = commands;
        }

        public Rover MoveRover(Rover rover)
        {
            var currentDirection = rover.Direction;
            var deltaOnYAxis = commands.Length;

            Position currentPosition = rover.Position;
            for (int i = 0; i < deltaOnYAxis; i++)
            {
                currentPosition = currentPosition.IncY();
            }

            return new Rover(currentDirection, currentPosition);
        }
    }

    public enum Direction
    {
        North
    }

    public class Position
    {

        private readonly int x;
        private readonly int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Position IncY()
        {
            return new Position(x, y + 1);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Position p = (Position)obj;
            return (x == p.x) && (y == p.y);
        }

        public override int GetHashCode()
        {
            return (x << 2) ^ y;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", x, y);
        }
    }
}
