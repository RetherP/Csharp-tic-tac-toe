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
        public static int[,] matix = null;
        public static void matrixbasicsetting() {
            //upload
            row = 3;
            column = 3;
            matix = new int[row,column];
            for(int i = 0;i < row;i++) {
                for(int j = 0;j < column;j++) {
                    matix[i,j] = counter++;
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
            Console.WriteLine("X is the starter");
            /*do {

                } while();*/
            }
        static void testwinner(int[,] matrix) {
            int row = 3;
            int column= 3;
            //row testing user X
            for(int i = 0;i < row;i++) {
                if(matix[row,column] == matix[row,column + 1]&& matix[row,column] == matix[row,column + 2]&& matix[row,column+1] == matix[row,column + 2]&&matix[row,column] == 'X') {
                    Console.Clear();
                    Console.WriteLine("X is the winner");
                    }
                }
            //column testing user Y
            for(int i = 0;i < column;i++) {
                if(matix[row,column] == matix[row + 1,column]&& matix[row+2,column] == matix[row,column]&& matix[row+1,column]==matix[row+2,column]) {
                    }
                }
            }
        static void Main(string[] args) {
            matrixbasicsetting();
            game();
            Console.ReadKey();
            }
        }
    }