using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe {
    class Program {
        public static int row;
        public static int column;
        public static int counter;
        public static string[,] matix = null;
        public static bool winner = false;
        public static void matrixbasicsetting() {
            //upload
            row = 3;
            column = 3;
            matix = new string[row,column];
            for(int i = 0;i < row;i++) {
                for(int j = 0;j < column;j++) {
                    matix[i,j] = Convert.ToString(counter++);
                    }
                }
            //output
            for(int i = 0;i < row;i++) {
                for(int j = 0;j < column;j++) {
                    Console.Write(Convert.ToString(string.Format("{0}\t",matix[i,j])));
                    }
                Console.WriteLine();
                }
            }
        public static void game() {
            int row = 3;
            int column = 3;
            Console.WriteLine("X is the starter");
            do {               
                //X input
                Console.WriteLine("Please give the X's place");
                string x = Console.ReadLine();
                //upload to the matrix
                for(int i = 0;i < row ;i++) {
                    for(int j = 0;j < column;j++) {
                        if(matix[i,j] == x) {
                            matix[i,j] = "X";
                            break;
                            }
                        else
                            continue;
                        }
                    }
                //output the new matrix
                for(int i = 0;i < row;i++) {
                    for(int j = 0;j < column;j++) {
                        Console.Write(Convert.ToString(string.Format("{0}\t",matix[i,j])));
                        }
                    Console.WriteLine();
                    }
                testwinner();
                if(winner == true) {
                    break;
                    }
                Console.WriteLine("Please give the O's place");
                string o= Console.ReadLine();          
                //upload to the matrix
                for(int i = 0;i < row;i++) {
                    for(int j = 0;j < column;j++) {
                        if(matix[i,j] == o) {
                            matix[i,j] = "O";
                            break;
                            } else
                            continue;
                        }
                    }
                //output the new matrix
                for(int i = 0;i < row;i++) {
                    for(int j = 0;j < column;j++) {
                        Console.Write(Convert.ToString(string.Format("{0}\t",matix[i,j])));
                        }
                    Console.WriteLine();
                    }
                testwinner();
                } while(winner == false);
            }
        static void testwinner() {
            int row;
            int column;
            //row testing
            row = 3;
            column = 0;
            for(int i = 0;i < row;i++) {               
                    if(matix[i,column] == matix[i,column + 1] && matix[i,column] == matix[i,column + 2] && matix[i,column + 1] == matix[i,column + 2]) {
                        Console.Clear();
                        Console.WriteLine($"{matix[i,column]} is the winner");
                        winner = true;
                        break;
                        }
                    
                }
            //column testing
            row = 0;
            column = 3;
            for(int i = 0;i < column;i++) {
                if(matix[row,i] == matix[row + 1,i]&& matix[row+2,i] == matix[row,i]&& matix[row+1,i]==matix[row+2,i] ) {
                    Console.Clear();
                    Console.WriteLine($"{matix[row,i]} is the winner");
                    winner = true;
                    break;
                    }
                }
            //other tests
            //diagnal n0.1
            if(matix[0,0] == matix[1,1] && matix[1,1] == matix[2,2]&& matix[2,2] == matix[0,0]) {
                Console.Clear();
                Console.WriteLine($"{matix[0,0]} is the winner");
                winner = true;
                }
            //diagnal n0.2
            if(matix[0,2] == matix[1,1] && matix[1,1] == matix[2,0] && matix[2,0] == matix[0,2]) {
                Console.Clear();
                Console.WriteLine($"{matix[0,2]} is the winner");
                winner = true;
                }

            }
        static void Main(string[] args) {
            matrixbasicsetting();
            game();
            Console.ReadKey();
            }
        }
    }