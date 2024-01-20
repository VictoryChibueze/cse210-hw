using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using learning02;

public class Resume
{
    public string personName;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {personName}");
        Console.WriteLine("Jobs");
        
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetail();
        }

        
    }


}

