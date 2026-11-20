using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020004A2 RID: 1186
public static class egg
{
	// Token: 0x06001E29 RID: 7721 RVA: 0x000A767C File Offset: 0x000A587C
	static egg()
	{
		egg.bk = new Dictionary<string, int>();
		egg.bk[egg.x] = 0;
		egg.bk[egg.y] = 0;
		egg.bk[egg.z] = 0;
		egg.bk[egg.aa] = 0;
		egg.bk[egg.ab] = 1;
		egg.bk[egg.ac] = 1;
		egg.bk[egg.ad] = 1;
		egg.bk[egg.ae] = 1;
		egg.bk[egg.af] = 1;
		egg.bk[egg.ag] = 2;
		egg.bk[egg.ah] = 2;
		egg.bk[egg.ai] = 2;
		egg.bk[egg.aj] = 2;
		egg.bk[egg.ak] = 2;
		egg.bk[egg.an] = 2;
		egg.bk[egg.al] = 2;
		egg.bk[egg.am] = 2;
		egg.bk[egg.ao] = 2;
		egg.bk[egg.ar] = 2;
		egg.bk[egg.ap] = 2;
		egg.bk[egg.aq] = 2;
		egg.bk[egg.@as] = 3;
		egg.bk[egg.av] = 3;
		egg.bk[egg.at] = 3;
		egg.bk[egg.au] = 3;
		egg.bk[egg.aw] = 3;
		egg.bk[egg.az] = 3;
		egg.bk[egg.ax] = 3;
		egg.bk[egg.ay] = 3;
		egg.bk[egg.a0] = 3;
		egg.bk[egg.a3] = 4;
		egg.bk[egg.a1] = 4;
		egg.bk[egg.a2] = 4;
		egg.bk[egg.a4] = 4;
		egg.bk[egg.a7] = 4;
		egg.bk[egg.a6] = 4;
		egg.bk[egg.a5] = 4;
		egg.bk[egg.a8] = 4;
		egg.bk[egg.bb] = 4;
		egg.bk[egg.ba] = 4;
		egg.bk[egg.a9] = 4;
		egg.bk[egg.bc] = 4;
		egg.bk[egg.bf] = 4;
		egg.bk[egg.be] = 4;
		egg.bk[egg.bd] = 4;
		egg.bk[egg.bg] = 5;
		egg.bk[egg.bj] = 5;
		egg.bk[egg.bi] = 5;
		egg.bk[egg.bh] = 5;
	}

	// Token: 0x06001E2A RID: 7722 RVA: 0x000A7F40 File Offset: 0x000A6140
	public static int b(string A_0)
	{
		int result;
		if (egg.bk.TryGetValue(A_0, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x000A7F64 File Offset: 0x000A6164
	public static int a(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return 0;
		}
		int lineSpacing;
		if (!egg.bl.TryGetValue(A_0, out lineSpacing))
		{
			cne service = bpo.GetService<cne>();
			if (service != null)
			{
				SpriteFont resource = service.GetResource<SpriteFont>(A_0, null);
				if (resource != null)
				{
					lineSpacing = resource.LineSpacing;
				}
				egg.bl[A_0] = lineSpacing;
			}
		}
		return lineSpacing;
	}

	// Token: 0x040012FF RID: 4863
	public static readonly string a = Path.Combine(d5x.i, "A16");

	// Token: 0x04001300 RID: 4864
	public static readonly string b = Path.Combine(d5x.i, "A20");

	// Token: 0x04001301 RID: 4865
	public static readonly string c = Path.Combine(d5x.i, "A22");

	// Token: 0x04001302 RID: 4866
	public static readonly string d = Path.Combine(d5x.i, "A24");

	// Token: 0x04001303 RID: 4867
	public static readonly string e = Path.Combine(d5x.i, "A26");

	// Token: 0x04001304 RID: 4868
	public static readonly string f = Path.Combine(d5x.i, "A30");

	// Token: 0x04001305 RID: 4869
	public static readonly string g = Path.Combine(d5x.i, "A32");

	// Token: 0x04001306 RID: 4870
	public static readonly string h = Path.Combine(d5x.i, "A34");

	// Token: 0x04001307 RID: 4871
	public static readonly string i = Path.Combine(d5x.i, "A36");

	// Token: 0x04001308 RID: 4872
	public static readonly string j = Path.Combine(d5x.i, "A38");

	// Token: 0x04001309 RID: 4873
	public static readonly string k = Path.Combine(d5x.i, "A40");

	// Token: 0x0400130A RID: 4874
	public static readonly string l = Path.Combine(d5x.i, "A42");

	// Token: 0x0400130B RID: 4875
	public static readonly string m = Path.Combine(d5x.i, "A44");

	// Token: 0x0400130C RID: 4876
	public static readonly string n = Path.Combine(d5x.i, "T6");

	// Token: 0x0400130D RID: 4877
	public static readonly string o = Path.Combine(d5x.i, "T6i");

	// Token: 0x0400130E RID: 4878
	public static readonly string p = Path.Combine(d5x.i, "T6b");

	// Token: 0x0400130F RID: 4879
	public static readonly string q = Path.Combine(d5x.i, "T7b");

	// Token: 0x04001310 RID: 4880
	public static readonly string r = Path.Combine(d5x.i, "T8");

	// Token: 0x04001311 RID: 4881
	public static readonly string s = Path.Combine(d5x.i, "T8b");

	// Token: 0x04001312 RID: 4882
	public static readonly string t = Path.Combine(d5x.i, "T9");

	// Token: 0x04001313 RID: 4883
	public static readonly string u = Path.Combine(d5x.i, "T9i");

	// Token: 0x04001314 RID: 4884
	public static bool v = false;

	// Token: 0x04001315 RID: 4885
	public static readonly string w = Path.Combine(d5x.i, "C5");

	// Token: 0x04001316 RID: 4886
	public static readonly string x = Path.Combine(d5x.i, "C9");

	// Token: 0x04001317 RID: 4887
	public static readonly string y = Path.Combine(d5x.i, "C9b");

	// Token: 0x04001318 RID: 4888
	public static readonly string z = Path.Combine(d5x.i, "C9sb");

	// Token: 0x04001319 RID: 4889
	public static readonly string aa = Path.Combine(d5x.i, "C9i");

	// Token: 0x0400131A RID: 4890
	public static readonly string ab = Path.Combine(d5x.i, "C10");

	// Token: 0x0400131B RID: 4891
	public static readonly string ac = Path.Combine(d5x.i, "C10b");

	// Token: 0x0400131C RID: 4892
	public static readonly string ad = Path.Combine(d5x.i, "C10b");

	// Token: 0x0400131D RID: 4893
	public static readonly string ae = Path.Combine(d5x.i, "C10sbi");

	// Token: 0x0400131E RID: 4894
	public static readonly string af = Path.Combine(d5x.i, "C10i");

	// Token: 0x0400131F RID: 4895
	public static readonly string ag = Path.Combine(d5x.i, "C11");

	// Token: 0x04001320 RID: 4896
	public static readonly string ah = Path.Combine(d5x.i, "C11b");

	// Token: 0x04001321 RID: 4897
	public static readonly string ai = Path.Combine(d5x.i, "C11sb");

	// Token: 0x04001322 RID: 4898
	public static readonly string aj = Path.Combine(d5x.i, "C11i");

	// Token: 0x04001323 RID: 4899
	public static readonly string ak = Path.Combine(d5x.i, "C12");

	// Token: 0x04001324 RID: 4900
	public static readonly string al = Path.Combine(d5x.i, "C12b");

	// Token: 0x04001325 RID: 4901
	public static readonly string am = Path.Combine(d5x.i, "C12sb");

	// Token: 0x04001326 RID: 4902
	public static readonly string an = Path.Combine(d5x.i, "C12i");

	// Token: 0x04001327 RID: 4903
	public static readonly string ao = Path.Combine(d5x.i, "C13");

	// Token: 0x04001328 RID: 4904
	public static readonly string ap = Path.Combine(d5x.i, "C13b");

	// Token: 0x04001329 RID: 4905
	public static readonly string aq = Path.Combine(d5x.i, "C13b");

	// Token: 0x0400132A RID: 4906
	public static readonly string ar = Path.Combine(d5x.i, "C13i");

	// Token: 0x0400132B RID: 4907
	public static readonly string @as = Path.Combine(d5x.i, "C14");

	// Token: 0x0400132C RID: 4908
	public static readonly string at = Path.Combine(d5x.i, "C14b");

	// Token: 0x0400132D RID: 4909
	public static readonly string au = Path.Combine(d5x.i, "C14sb");

	// Token: 0x0400132E RID: 4910
	public static readonly string av = Path.Combine(d5x.i, "C14i");

	// Token: 0x0400132F RID: 4911
	public static readonly string aw = Path.Combine(d5x.i, "C16");

	// Token: 0x04001330 RID: 4912
	public static readonly string ax = Path.Combine(d5x.i, "C16b");

	// Token: 0x04001331 RID: 4913
	public static readonly string ay = Path.Combine(d5x.i, "C16sb");

	// Token: 0x04001332 RID: 4914
	public static readonly string az = Path.Combine(d5x.i, "C16i");

	// Token: 0x04001333 RID: 4915
	public static readonly string a0 = Path.Combine(d5x.i, "C18");

	// Token: 0x04001334 RID: 4916
	public static readonly string a1 = Path.Combine(d5x.i, "C18b");

	// Token: 0x04001335 RID: 4917
	public static readonly string a2 = Path.Combine(d5x.i, "C18sb");

	// Token: 0x04001336 RID: 4918
	public static readonly string a3 = Path.Combine(d5x.i, "C18i");

	// Token: 0x04001337 RID: 4919
	public static readonly string a4 = Path.Combine(d5x.i, "C19");

	// Token: 0x04001338 RID: 4920
	public static readonly string a5 = Path.Combine(d5x.i, "C19sb");

	// Token: 0x04001339 RID: 4921
	public static readonly string a6 = Path.Combine(d5x.i, "C19b");

	// Token: 0x0400133A RID: 4922
	public static readonly string a7 = Path.Combine(d5x.i, "C19i");

	// Token: 0x0400133B RID: 4923
	public static readonly string a8 = Path.Combine(d5x.i, "C20");

	// Token: 0x0400133C RID: 4924
	public static readonly string a9 = Path.Combine(d5x.i, "C20sb");

	// Token: 0x0400133D RID: 4925
	public static readonly string ba = Path.Combine(d5x.i, "C20b");

	// Token: 0x0400133E RID: 4926
	public static readonly string bb = Path.Combine(d5x.i, "C20i");

	// Token: 0x0400133F RID: 4927
	public static readonly string bc = Path.Combine(d5x.i, "C22");

	// Token: 0x04001340 RID: 4928
	public static readonly string bd = Path.Combine(d5x.i, "C22sb");

	// Token: 0x04001341 RID: 4929
	public static readonly string be = Path.Combine(d5x.i, "C22b");

	// Token: 0x04001342 RID: 4930
	public static readonly string bf = Path.Combine(d5x.i, "C22i");

	// Token: 0x04001343 RID: 4931
	public static readonly string bg = Path.Combine(d5x.i, "C24");

	// Token: 0x04001344 RID: 4932
	public static readonly string bh = Path.Combine(d5x.i, "C24sb");

	// Token: 0x04001345 RID: 4933
	public static readonly string bi = Path.Combine(d5x.i, "C24b");

	// Token: 0x04001346 RID: 4934
	public static readonly string bj = Path.Combine(d5x.i, "C24i");

	// Token: 0x04001347 RID: 4935
	private static readonly Dictionary<string, int> bk;

	// Token: 0x04001348 RID: 4936
	private static readonly Dictionary<string, int> bl = new Dictionary<string, int>();
}
