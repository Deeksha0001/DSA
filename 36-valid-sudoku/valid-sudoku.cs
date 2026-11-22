public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxs = new HashSet<char>[9];
        for(int i = 0; i<9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxs[i] = new HashSet<char>();
        }
        for(int r = 0; r<9; r++){
            for(int c = 0; c<9; c++){
                char num = board[r][c];
                if(num == '.')
                continue;
                int boxIndex = (r/3)*3+(c/3);
                if(rows[r].Contains(num)||cols[c].Contains(num)||boxs[boxIndex].Contains(num))
                {
                    return false;
                }
                rows[r].Add(num);
                cols[c].Add(num);
                boxs[boxIndex].Add(num);
            }
        }
        return true;
    }
}