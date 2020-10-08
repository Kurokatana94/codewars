using System;

namespace CodeWars
{
    class Kata
    {
        public string mazeRunner(int[,] maze, string[] directions)
        {
          int y = 0, x = 0;
          string result = "";
          for(int i=0;i<maze.GetLength(0);i++){
            bool isStart = false;
            for(int j=0;j<maze.GetLength(1);j++){
              int pos = maze[i,j];
              if(pos==2){
                y=i;
                x=j;
                isStart=true;
                break;
              }
            }
            if(isStart) break;
          }
          foreach(string direction in directions){
            int checkY = y;
            int checkX = x;
            switch(direction){
                case "N":
                  checkY--;
                  break;
                case "S":
                  checkY++;
                  break;                
                case "W":
                  checkX--;
                  break;
                case "E":
                  checkX++;
                  break;
            }
            if(checkY>=0 && checkX>=0 && checkY<maze.GetLength(0) && checkX<maze.GetLength(1)){
              y = checkY;
              x = checkX;
              int pos = maze[y,x];              
              if(pos==1){
                result = "Dead";
                break;
              }else if(pos==3){
                result = "Finish";
                break;
              }
            }else{
              result = "Dead";
              break;              
            }
          }
          if(result == "")
            return "Lost";
          else return result;                  
        }
    }
}
