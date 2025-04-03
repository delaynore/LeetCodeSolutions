namespace LeetCodeSolutions.TwoPointers;

internal class BackspaceStringCompare_844
{
    public bool BackspaceCompare(string s, string t)
    {
        var accS = 0;
        var accT = 0;
        var ps = s.Length - 1;
        var pt = t.Length - 1;

        while (ps > -1 && pt > -1)
        {
            if (s[ps] == '#') accS += 2;
            if (accS > 0)
            {
                ps--;
                accS--;
                continue;
            }
            if (t[pt] == '#') accT += 2;
            if (accT > 0)
            {
                pt--;
                accT--;
                continue;
            }

            if (s[ps] != t[pt])
            {
                return false;
            }

            ps--;
            pt--;
        }

        while (ps > -1)
        {
            if (s[ps] == '#') accS += 2;
            if (accS > 0)
            {
                ps--;
                accS--;
                continue;
            }

            break;
        }

        while (pt > -1)
        {
            if (t[pt] == '#') accT += 2;
            if (accT > 0)
            {
                pt--;
                accT--;
                continue;
            }
            break;
        }

        return ps + pt == -2;
    }
}
