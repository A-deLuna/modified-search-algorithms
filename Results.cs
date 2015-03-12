namespace modifiedSearch{
    public class Results{
        public String name;
        public int comparisons;
        public int swaps;
        public Results(String name){
            this.name = name;
            comparisons = 0;
            swaps = 0;
        }
        public Results(){
            this.name = "";
            comparisons = 0;
            swaps = 0;
        }
    }
}
