using System;

public class MathAssignment : Assignment
{
    private double _textbookSection;
    private int _problem;
    private int _endProblem;

    public double GetTextbookSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(double textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public void SetProblem(int problem, int endProblem)
    {
        _problem = problem;
        _endProblem = endProblem;
    }

    public void SetProblems(int problem)
    {
        _problem = problem;
        _endProblem = 0;
    }
    public string GetHomeworkList()
    {
        string problems = $"Section {_textbookSection} Problems {_problem}";
        if (_problem != 0)
        {
            problems += $"-{_endProblem}";
        }
        return problems;
    }
}