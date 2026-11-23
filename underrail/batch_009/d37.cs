using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000654 RID: 1620
public static class d37
{
	// Token: 0x06002919 RID: 10521 RVA: 0x000EA614 File Offset: 0x000E8814
	public static List<dxs> e()
	{
		d37.b();
		return d37.c;
	}

	// Token: 0x0600291A RID: 10522 RVA: 0x000EA620 File Offset: 0x000E8820
	public static List<dxs> d()
	{
		d37.b();
		return d37.d;
	}

	// Token: 0x0600291B RID: 10523 RVA: 0x000EA62C File Offset: 0x000E882C
	public static Dictionary<string, Texture2D> c()
	{
		d37.b();
		return d37.e;
	}

	// Token: 0x0600291C RID: 10524 RVA: 0x000EA63C File Offset: 0x000E883C
	public static void b()
	{
		if (!d37.a)
		{
			d37.a(Gender.Male, d37.c);
			d37.a(Gender.Female, d37.d);
			d37.a(Gender.Genderless, null);
			d37.a();
			d37.f["at_f"] = "at";
			d37.f["prbio_f"] = "prbio";
			d37.f["bladeling1"] = "bladeling";
			d37.f["bladeling2"] = "bladeling";
			d37.f["bladeling3"] = "bladeling";
			d37.f["ri_s"] = "ri";
			d37.f["ri_c_s"] = "ri_c";
			d37.f["ri_f_s"] = "ri_f";
			d37.f["ri_f_c_s"] = "ri_f_c";
			d37.f["tchsol_f"] = "tchsol";
			d37.f["bh_f"] = "bh";
			d37.f["bls_f"] = "bls";
			d37.f["praem_f"] = "praem";
			d37.f["xpbl_srobmd"] = "xpbl_srobm";
			d37.f["xpbl_srobfd"] = "xpbl_srobf";
			d37.f["xpbl_prss"] = "xpbl_prs";
			d37.f["xpbl_agsc"] = "xpbl_ags1";
			d37.f["xpbl_sht_n"] = "xpbl_sht";
			d37.f["xpbl_sht_s"] = "xpbl_sht";
			d37.f["xpbl_sht_w"] = "xpbl_sht";
			d37.f["xpbl_sht_e"] = "xpbl_sht";
			d37.f["xpbl_svgkgt"] = "xpbl_svgkg";
			d37.f["xpbl_svbl1"] = "xpbl_svgw2";
			d37.f["xpbl_svbl2"] = "xpbl_svgw3";
			d37.f["xpbl_svbl3"] = "xpbl_svgw4";
			d37.f["xpbl_mtr_pr_f2"] = "xpbl_pr_f2";
			d37.f["xpbl_mtr_pr2"] = "xpbl_pr2";
			d37.f["xpbl_mtr_pr5"] = "xpbl_pr5";
			d37.f["xpbl_mtr_pr6"] = "xpbl_pr6";
			d37.f["xpbl_mtr_prdv"] = "xpbl_prdv";
			foreach (string text in new string[]
			{
				"mhun1",
				"mhun2",
				"mhun3"
			})
			{
				foreach (string arg in new string[]
				{
					"ac",
					"acl",
					"bob",
					"bobl",
					"crc",
					"eb",
					"pb",
					"pbl",
					"rc",
					"nb"
				})
				{
					d37.f[string.Format("{0}_{1}", text, arg)] = text;
				}
			}
			foreach (string arg2 in new string[]
			{
				"xpbl_srobm",
				"xpbl_srobmd"
			})
			{
				foreach (string arg3 in new string[]
				{
					"ac",
					"acl",
					"bob",
					"bobl",
					"crc",
					"eb",
					"pb",
					"pbl",
					"rc",
					"nb"
				})
				{
					d37.f[string.Format("{0}_{1}", arg2, arg3)] = "xpbl_srobm";
				}
			}
			d37.a = true;
		}
	}

	// Token: 0x0600291D RID: 10525 RVA: 0x000EAA68 File Offset: 0x000E8C68
	public static Texture2D d(string A_0)
	{
		Texture2D texture2D = d37.a(A_0, "h");
		if (texture2D == null)
		{
			texture2D = d37.c(A_0);
		}
		return texture2D;
	}

	// Token: 0x0600291E RID: 10526 RVA: 0x000EAA90 File Offset: 0x000E8C90
	public static Texture2D c(string A_0)
	{
		return d37.a(A_0, "l");
	}

	// Token: 0x0600291F RID: 10527 RVA: 0x000EAAA0 File Offset: 0x000E8CA0
	public static Texture2D b(string A_0)
	{
		return d37.a(A_0, "s");
	}

	// Token: 0x06002920 RID: 10528 RVA: 0x000EAAB0 File Offset: 0x000E8CB0
	public static Texture2D a(string A_0, bool A_1)
	{
		cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
		if (serviceOrThrow != null)
		{
			Texture2D texture2D = null;
			if (A_1)
			{
				texture2D = serviceOrThrow.us("Portraits\\Backgrounds\\" + A_0 + "_h", new double?((double)-1));
			}
			if (texture2D == null)
			{
				texture2D = serviceOrThrow.us("Portraits\\Backgrounds\\" + A_0, new double?((double)-1));
			}
			return texture2D;
		}
		return null;
	}

	// Token: 0x06002921 RID: 10529 RVA: 0x000EAB14 File Offset: 0x000E8D14
	private static Texture2D a(string A_0, string A_1)
	{
		d37.b();
		cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
		if (A_0 != null)
		{
			string text;
			if (!d37.f.TryGetValue(A_0.ToLowerInvariant(), out text))
			{
				text = A_0.ToLowerInvariant();
			}
			dxs dxs;
			if (!string.IsNullOrEmpty(text) && d37.b.TryGetValue(text, out dxs))
			{
				Texture2D texture2D;
				if (dxs.b)
				{
					d37.e.TryGetValue(text + "_" + A_1, out texture2D);
				}
				else
				{
					texture2D = serviceOrThrow.us(dxs.d + "_" + A_1, new double?((double)-1));
				}
				if (texture2D != null)
				{
					return texture2D;
				}
			}
		}
		return serviceOrThrow.us("portraits\\default_" + A_1, new double?((double)-1));
	}

	// Token: 0x06002922 RID: 10530 RVA: 0x000EABD8 File Offset: 0x000E8DD8
	private static void a(Gender A_0, List<dxs> A_1)
	{
		string text = Path.Combine(dr3.d().lf(), "Portraits\\" + A_0.ToString());
		if (Directory.Exists(text))
		{
			string[] files = Directory.GetFiles(text, "*_l.*");
			for (int i = 0; i < files.Length; i++)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[i]);
				if (fileNameWithoutExtension.Length > 2)
				{
					string text2 = fileNameWithoutExtension.Substring(0, fileNameWithoutExtension.Length - 2).ToLowerInvariant();
					if (!d37.b.ContainsKey(text2))
					{
						dxs dxs = new dxs();
						dxs.c = text2;
						dxs.a = A_0;
						dxs.d = "Portraits\\" + A_0.ToString() + "\\" + text2;
						d37.b[text2] = dxs;
						if (A_1 != null)
						{
							A_1.Add(dxs);
						}
					}
				}
			}
		}
	}

	// Token: 0x06002923 RID: 10531 RVA: 0x000EACD0 File Offset: 0x000E8ED0
	private static void a()
	{
		dr3.d().lf();
		string text = d5x.j();
		if (Directory.Exists(text))
		{
			string[] files = Directory.GetFiles(text, "*_l.png");
			for (int i = 0; i < files.Length; i++)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[i]);
				if (fileNameWithoutExtension.Length > 2)
				{
					string text2 = fileNameWithoutExtension.Substring(0, fileNameWithoutExtension.Length - 2).ToLowerInvariant();
					if (!d37.b.ContainsKey(text2))
					{
						dxs dxs = new dxs();
						dxs.c = text2;
						dxs.a = Gender.Genderless;
						dxs.b = true;
						d37.e[text2 + "_h"] = d37.a(Path.Combine(text, text2 + "_h.png"));
						d37.e[text2 + "_l"] = d37.a(Path.Combine(text, text2 + "_l.png"));
						d37.e[text2 + "_s"] = d37.a(Path.Combine(text, text2 + "_s.png"));
						d37.b[text2] = dxs;
						d37.c.Add(dxs);
						d37.d.Add(dxs);
					}
				}
			}
		}
	}

	// Token: 0x06002924 RID: 10532 RVA: 0x000EAE28 File Offset: 0x000E9028
	private static Texture2D a(string A_0)
	{
		if (File.Exists(A_0))
		{
			try
			{
				bef serviceOrThrow = bpo.GetServiceOrThrow<bef>();
				Stream stream = File.OpenRead(A_0);
				Texture2D result = Texture2D.FromStream(serviceOrThrow.k9(), stream);
				stream.Close();
				return result;
			}
			catch
			{
			}
		}
		return null;
	}

	// Token: 0x04001672 RID: 5746
	private static bool a;

	// Token: 0x04001673 RID: 5747
	private static Dictionary<string, dxs> b = new Dictionary<string, dxs>();

	// Token: 0x04001674 RID: 5748
	private static List<dxs> c = new List<dxs>();

	// Token: 0x04001675 RID: 5749
	private static List<dxs> d = new List<dxs>();

	// Token: 0x04001676 RID: 5750
	private static Dictionary<string, Texture2D> e = new Dictionary<string, Texture2D>();

	// Token: 0x04001677 RID: 5751
	private static Dictionary<string, string> f = new Dictionary<string, string>();
}
