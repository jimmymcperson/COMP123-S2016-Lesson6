﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public abstract class GameObject
    {

        // PRIVATE INSTANCE VARIABLES =========================================================================

        private int _attack;
        private int _defense;
        private int _lives;
        private string _name;
        private int _speed;
        private float _direction; // angle in degrees
        private Vector2 _position; // positions in 2-dimensional space
        private Vector2 _facing; // where the game object is looking at in 2-dimensional space


        // PUBLIC PROPERTIES ========================================================================

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                 this._name = value;
            }
        }

        public int Lives
        {
            get
            {
                return this._lives;
            }

            set
            {
                this._lives = value;
            }
        }

        public int Speed
        {
            get
            {
                return this._speed;
            }

            set
            {
                this._speed = value;
            }
        }

        public int Attack
        {
            get
            {
                return this._attack;
            }

            set
            {
                this._attack = value;
            }
        }

        public int Defense
        {
            get
            {
                return this._defense;
            }

            set
            {
                this._defense = value;
            }
        }

        public Vector2 Position
        {
            get
            {
                return this._position;
            }

            set
            {
                this._position = value;
            }
        }

        public Vector2 Facing
        {
            get
            {
                return this._facing;
            }

            set
            {
                this._facing = value;
            }
        }

        public float Direction
        {
            get
            {
                return this._direction;
            }

            set
            {
                this._direction = value;
            }
        }

        // CONSTRUCTOR =======================================================================================

        public GameObject(string name)
        {
            this.Name = name;
            this._initialize();
        }


        // PRIVATE METHODS ==================================================================================

        private void _initialize()
        {
            this._attack = 0;
            this._defense = 0;
            this._lives = 0;
            this._speed = 0;
            this._direction = 0f;
            Vector2 _position = new Vector2();
            Vector2 _facing = new Vector2();
        }

        // PUBLIC METHODS =======================================================================================

        public void MoveRight()
        {
            Console.WriteLine("{0} is moving right", this.Name);
        }

        public void MoveLeft()
        {
            Console.WriteLine("{0} is moving left", this.Name);
        }

        public void MoveForward()
        {
            Console.WriteLine("{0} is moving forward", this.Name);
        }

        public void MoveBack()
        {
            Console.WriteLine("{0} is moving back", this.Name);
        }

        public void TurnLeft()
        {
            Console.WriteLine("{0} is turning left", this.Name);
        }

        public void TurnRight()
        {
            Console.WriteLine("{0} is turning right", this.Name);
        }
    }
}