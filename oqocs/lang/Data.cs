using System.Collections.Generic;

namespace oqocs.lang
{
    public static class Data
    {
        public static List<string> Vowels => new List<string>
        {
            "i", "u", "ə", "o", "e","a",
        };

        public static List<string> Consonants => new List<string>
        {
            "p", "t", "ky", "k", "q", "ts", "ch", "s", "sh", "x",
            "h", "z", "zh", "m", "n", "ny", "tl", "w", "l", "y",
        };

        public static List<string> AcceptableClusters => new List<string>
        {
            "chh", "chk", "chky", "chl", "chm", "chn", "chny", "chp", "chq", "cht", "chtl", "chts", "chw", "chx", "chy",
            "hch", "hk", "hl", "hm", "hn", "hny", "hp", "hq", "hs", "hsh", "ht", "htl", "hts", "hw", "hy", "hz", "hzh",
            "kch", "kh", "kl", "km", "kn", "kny", "kp", "ks", "ksh", "kt", "ktl", "kts", "kw", "kz", "kzh",
            "lch", "lh", "lk", "lky", "lm", "ln", "lny", "lp", "lq", "ls", "lsh", "ltl", "lts", "lw", "lx", "ly", "lz", "lzh",
            "mch", "mh", "mk", "mky", "ml", "mn", "mny", "mp", "mq", "ms", "msh", "mt", "mtl", "mts", "mw", "mx", "my", "mz", "mzh",
            "nch", "nh", "nk", "nky", "nl", "nm", "np", "nq", "ns", "nsh", "nt", "ntl", "nts", "nw", "nx", "ny", "nz", "nzh",
            "pch", "ph", "pk", "pky", "pl", "pm", "pn", "pny", "pq", "ps", "psh", "pt", "ptl", "pts", "pw", "px", "py", "pz", "pzh",
            "qch", "qh", "ql", "qm", "qn", "qny", "qp", "qs", "qsh", "qt", "qtl", "qts", "qw", "qy", "qz", "qzh",
            "sh", "sch", "shch", "shh", "shk", "shky", "shl", "shm", "shn", "shny", "shp", "shq", "shs", "sht", "shtl", "shts", "shw","shx", "shy",
            "sk", "sky", "sl", "sm", "sn", "sny", "sp", "sq", "st", "stl", "sts", "sw", "sx", "sy",
            "tl", "tch", "th", "tk", "tky", "tlch", "tlh", "tlk", "tlky", "tlm", "tln", "tlny", "tlp", "tlq", "tlt", "tlts", "tlw", "tlx", "tly", "tlz", "tlzh", "tm", "tn", "tny", "tp", "tq", "tsch", "tsh", "tsh", "tsk", "tsky", "tsl", "tsm", "tsn", "tsny", "tsp", "tsq", "tst", "tstl", "tsw", "tsx", "tsy", "ttl", "tw", "tx", "ty", "tz", "tzh",
            "xch", "xl", "xm", "xn", "xny", "xp", "xs", "xsh", "xt", "xtl", "xts", "xw", "xy", "xz","xzh",
            "zh", "zch", "zhch", "zhh", "zhk", "zhky", "zhl", "zhm","zhn", "zhny", "zhp", "zhq", "zht", "zhtl", "zhts", "zhw", "zhx", "zhy", "zk", "zky", "zl", "zm", "zn", "zny", "zp", "zq", "zt", "ztl", "zts", "zw", "zx", "zy",
        };
    }
}