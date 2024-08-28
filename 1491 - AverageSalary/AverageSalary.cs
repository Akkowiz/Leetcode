public class Solution {
    public double Average(int[] salary) {
        List<int> SalaryList = new List<int>(salary);
        int SalarySum = 0;
        SalaryList.Remove(SalaryList.Max());
        SalaryList.Remove(SalaryList.Min());
        int TotalElements = SalaryList.Count;

        foreach(int Salary in SalaryList){
            SalarySum += Salary;
        }
        double SalarySumDouble = Convert.ToDouble(SalarySum);
        double TotalElementsDouble = Convert.ToDouble(TotalElements);
        double Result = SalarySumDouble / TotalElementsDouble;
        return Result;
    }
}

