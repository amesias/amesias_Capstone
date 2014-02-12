using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ProcessPair
{
    public IntPtr handle;
    public String name;

    public ProcessPair(IntPtr handle, String name)
    {
        this.handle = handle;
        this.name = name;
    }

    public override string ToString()
    {
        return name;
    }
}

