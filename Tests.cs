public void RunFunctionDoorEventUnity()
        {
            lgr.TestLog(serDes.nameOfGame, serDes.versionOfGame, serDes.mathOfGame, "FunctionDoorEventUnity");            

            if (!cmd.checkForException())
            {
                //Add money
                lgr.Log("Inserting 100 dollars");
                if (!cmd.SendCredits(cmd.Insert_100_Dollars()))
                {
                    Assert.Inconclusive("Malfunction in SendCredits()");
                    return;
                }
            }
            else
            {
                return;
            }


            if (!cmd.checkForException())
            {
                //Choose denom
                lgr.Log("Selecting 1c denom");
                if (!cmd.SendCommandGameEngine(cmd.DenomChangeRequest(1000, true), 1, 5000))
                {
                    Assert.Inconclusive("Malfunction in SendCommandGameEngine()");
                }
            }
            else
            {
                return;
            }

            if (!cmd.checkForException())
            {
                //Play a game(s)
                lgr.Log("Play 1 game");
                if (!cmd.PlayQuickGameUnity(1, false))
                {
                    Assert.Inconclusive("Malfunction in PlayQuickGameUnity()");
                    return;

                }
            }
            else
            {
                return;
            }
            
            //allow enough time for reels to begin spinning
            Thread.Sleep(500);

                     
                        
            if (!cmd.checkForException())
            {
                //Open main door while reels spin
                lgr.Log("Opening main door while reels spin");
                if (!cmd.SendCommand(cmd.MainDoorOpen(), 1, 500))
                {
                    Assert.Inconclusive("Malfunction in SendCommand()");
                    return;
                }
            }
            else
            {
                return;
            }

            if (!cmd.checkForException())
            {
                //Close main door
                lgr.Log("Closing main door");
                if (!cmd.SendCommand(cmd.MainDoorClose(), 1, 5000))
                {
                    Assert.Inconclusive("Malfunction in SendCommand()");
                }
            }
            else
            {
                return;
            }

            //----------------------------------------------------------------------
            
            
            
            //Start game with quickstop, door event during stop
            if (!cmd.checkForException())
            {
                //Play a game(s)
                lgr.Log("Play 1 game");
                if (!cmd.PlayQuickGameUnity(1, false))
                {
                    Assert.Inconclusive("Malfunction in PlayQuickGameUnity()");
                    return;

                }
            }
            else
            {
                return;
            }
            
            Thread.Sleep(200);
            
            
            if (!cmd.checkForException())
            {
                //Play a game(s)
                lgr.Log("Attempting quickstop");
                if (!cmd.PlayQuickGameUnity(1, false))
                {
                    Assert.Inconclusive("Malfunction in PlayQuickGameUnity()");
                    return;

                }
            }
            else
            {
                return;
            }
            
            
            Thread.Sleep(200);
            
            
            if (!cmd.checkForException())
            {
                //Open main door while quickstopping
                lgr.Log("Opening main door while quickstopping");
                if (!cmd.SendCommand(cmd.MainDoorOpen(), 1, 500))
                {
                    Assert.Inconclusive("Malfunction in SendCommand()");
                    return;
                }
            }
            else
            {
                return;
            }

            if (!cmd.checkForException())
            {
                //Close main door
                lgr.Log("Closing main door");
                if (!cmd.SendCommand(cmd.MainDoorClose(), 1, 5000))
                {
                    Assert.Inconclusive("Malfunction in SendCommand()");
                }
            }
            else
            {
                return;
            }
            
            //----------------------------------------------------------------------
            
            
            //Start game with quickstop, door event after stop
            if (!cmd.checkForException())
            {
                //Play a game(s)
                lgr.Log("Play 1 game");
                if (!cmd.PlayQuickGameUnity(1, false))
                {
                    Assert.Inconclusive("Malfunction in PlayQuickGameUnity()");
                    return;

                }
            }
            else
            {
                return;
            }
            
            Thread.Sleep(200);
            
            
            if (!cmd.checkForException())
            {
                //Play a game(s)
                lgr.Log("Attempting quickstop");
                if (!cmd.PlayQuickGameUnity(1, false))
                {
                    Assert.Inconclusive("Malfunction in PlayQuickGameUnity()");
                    return;

                }
            }
            else
            {
                return;
            }
            
            
            Thread.Sleep(3000);
            
            
            if (!cmd.checkForException())
            {
                //Open main door after quickstopping
                lgr.Log("Opening main door after quickstopping");
                if (!cmd.SendCommand(cmd.MainDoorOpen(), 1, 500))
                {
                    Assert.Inconclusive("Malfunction in SendCommand()");
                    return;
                }
            }
            else
            {
                return;
            }

            if (!cmd.checkForException())
            {
                //Close main door
                lgr.Log("Closing main door");
                if (!cmd.SendCommand(cmd.MainDoorClose(), 1, 5000))
                {
                    Assert.Inconclusive("Malfunction in SendCommand()");
                }
            }
            else
            {
                return;
            }
            
            
            //-----------------------------------------------------------------------------
            
            //Door event after winning bangup
            if (!cmd.checkForException())
            {
                //Entering indexes
                if (!cmd.SendCommandPRG(cmd.ChooseThisIndex("1", 
                        "0", "0", "", serDes.nameOfGame), 1, 1000))

                {
                    Assert.Inconclusive("Malfunction in SendCommandPRG()");
                    return;
                }
            }
            else
            {
                return;
            }
            
            //initiate game w/ stop
            if (!cmd.checkForException())
            {
                //Play a game(s)
                lgr.Log("Play 1 game");
                if (!cmd.PlayMaxBetUnity(1, false))
                {
                    Assert.Inconclusive("Malfunction in PlayMaxBetUnity()");
                    return;

                }
            }
            else
            {
                return;
            }
            
            Thread.Sleep(3000);
            
            
            if (!cmd.checkForException())
            {
                //Open main door after winning bangup
                lgr.Log("Opening main door after winning bangup");
                if (!cmd.SendCommand(cmd.MainDoorOpen(), 1, 500))
                {
                    Assert.Inconclusive("Malfunction in SendCommand()");
                    return;
                }
            }
            else
            {
                return;
            }

            if (!cmd.checkForException())
            {
                //Close main door
                lgr.Log("Closing main door");
                if (!cmd.SendCommand(cmd.MainDoorClose(), 1, 5000))
                {
                    Assert.Inconclusive("Malfunction in SendCommand()");
                }
            }
            else
            {
                return;
            }
        }
        
        [Test]
        [Category("Exploratory Testing")]
        [Property("Name", "FunctionDoorEventUnity")]
        [Description("Performs door events during various states.")]
        public void FunctionDoorEventUnity()
        {
            try
            {
                for (int gameNumber = 1; gameNumber < howManyTimes + 1; gameNumber++)
                {
                    RunFunctionDoorEventUnity();
                }

                lgr.Log("The FunctionDoorEventUnity test is complete");
            }
            catch (Exception ex)
            {
                lgr.Log($"Malfunction in RunFunctionDoorEventUnity() {ex}");
            }
        }
