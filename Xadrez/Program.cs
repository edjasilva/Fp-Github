string[,] board = {

{ "BR1 " ,"BK1 " ,"BB1 " ,"BQw " ,"BKi " ,"BB2 " ,"BK2 " ,"BR2"},
{"BP1 " ,"BP2 " ,"BP3 " ,"BP4 " ,"BP5 " ,"BP6 " ,"BP7 " ,"BP8"},
{"","","","","","","",""},
{"","","","","","","",""},
{"","","","","","","",""},
{"","","","","","","",""},
{"WP1 " ,"WP2 " ,"WP3 " ,"WP4 " ,"WP5 " ,"WP6 " ,"WP7 " ,"WP8"},
{"WR1 " ,"WK1 " ,"WB1 ","WQw ","WKi ","WB2 ","WK2 ","WR2"}
};

void PrintBoard(String[,] board){
    System.Console.WriteLine("         A\t B\t C\t D\t E\t F\t G\t H\t");
    for(int i=0; i<board.GetLength(0); i++) {
        Console.Write($"{8-i}");
       
    for(int j=0; j<board.GetLength(1); j++){
        
         Console.Write( $"\t{board[i, j]} ");
    }
    Console.WriteLine();
}

}

void movePiece(string[,] board, string from, string to){
    


}

void findPiece(string[,] board, string piece) {
    
}




PrintBoard(board);

