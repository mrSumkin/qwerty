using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200116C RID: 4460
public static class bz9
{
	// Token: 0x06005F5E RID: 24414 RVA: 0x0028766C File Offset: 0x0028586C
	static bz9()
	{
		bz9.c();
		bz9.b();
		bz9.a();
	}

	// Token: 0x06005F5F RID: 24415 RVA: 0x00287688 File Offset: 0x00285888
	public static string a(CharacterState A_0, string A_1)
	{
		return A_0.ToString() + ((A_1 != null) ? A_1.ToLowerInvariant() : "");
	}

	// Token: 0x06005F60 RID: 24416 RVA: 0x002876B4 File Offset: 0x002858B4
	public static zx a(string A_0, string A_1, string A_2, Gender A_3, string A_4 = null)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			cde cde = bz9.e(A_0.ToLowerInvariant());
			if (cde != null)
			{
				zx zx = new zx();
				zx.d = cde.i;
				zx.c = cde.h;
				zx.e = cde.j;
				zx.f = cde.k;
				zx.g = cde.l;
				zx.h = A_4;
				zx.b = cde.e;
				string text;
				if (cde.f && !string.IsNullOrEmpty(A_1))
				{
					cnk service = bpo.GetService<cnk>();
					if ((cde.d == "pl" || cde.d == "pl_f") && !string.IsNullOrEmpty(A_4))
					{
						bool? flag;
						if (service == null)
						{
							flag = null;
						}
						else
						{
							ls ls = service.aq1();
							if (ls == null)
							{
								flag = null;
							}
							else
							{
								cnt cnt = ls.g();
								flag = ((cnt != null) ? new bool?(cnt.g) : null);
							}
						}
						bool? flag2 = flag;
						if (flag2.GetValueOrDefault(true))
						{
							text = cde.d + "_" + A_1 + "##base";
							goto IL_28A;
						}
					}
					text = cde.d + "_" + A_1;
				}
				else
				{
					cnk service2 = bpo.GetService<cnk>();
					if (cde.d == "pl" && !string.IsNullOrEmpty(A_4))
					{
						bool? flag3;
						if (service2 == null)
						{
							flag3 = null;
						}
						else
						{
							ls ls2 = service2.aq1();
							if (ls2 == null)
							{
								flag3 = null;
							}
							else
							{
								cnt cnt2 = ls2.g();
								flag3 = ((cnt2 != null) ? new bool?(cnt2.g) : null);
							}
						}
						bool? flag2 = flag3;
						if (flag2.GetValueOrDefault(true))
						{
							text = "pl##base";
							goto IL_28A;
						}
					}
					if (cde.d == "pl_f" && !string.IsNullOrEmpty(A_4))
					{
						bool? flag4;
						if (service2 == null)
						{
							flag4 = null;
						}
						else
						{
							ls ls3 = service2.aq1();
							if (ls3 == null)
							{
								flag4 = null;
							}
							else
							{
								cnt cnt3 = ls3.g();
								flag4 = ((cnt3 != null) ? new bool?(cnt3.g) : null);
							}
						}
						bool? flag2 = flag4;
						if (flag2.GetValueOrDefault(true))
						{
							text = "pl_f##base";
							goto IL_28A;
						}
					}
					text = cde.d;
				}
				IL_28A:
				text += "\\";
				string a_;
				string a_2;
				if (cde.g && !string.IsNullOrEmpty(A_2))
				{
					a_ = "_" + A_2;
					a_2 = A_2;
				}
				else
				{
					a_ = "";
					a_2 = "";
				}
				zx.a(cde, CharacterState.Idle, text, a_, a_2, false);
				zx.a(cde, CharacterState.Stunned, text, a_, a_2, false);
				zx.a(cde, CharacterState.Move, text, a_, a_2, false);
				zx.a(cde, CharacterState.Attack1, text, a_, a_2, true);
				zx.a(cde, CharacterState.Attack2, text, a_, a_2, true);
				zx.a(cde, CharacterState.LowerWeapon, text, a_, a_2, true);
				zx.a(cde, CharacterState.RaiseWeapon, text, a_, a_2, true);
				zx.a(cde, CharacterState.ShieldBash, text, a_, a_2, false);
				zx.a(cde, CharacterState.Die, text);
				zx.a(cde, CharacterState.OperateShort, text);
				zx.a(cde, CharacterState.Operating, text);
				zx.a(cde, CharacterState.Throw, text);
				zx.a(cde, CharacterState.CastingPsi, text);
				zx.a(cde, CharacterState.ChannelPsi, text);
				zx.a(cde, CharacterState.FinishPsi, text);
				if (A_1 == "exodr")
				{
					zx.a(cde, CharacterState.Custom1, text, a_, a_2, false);
				}
				else
				{
					zx.a(cde, CharacterState.Custom1, text);
				}
				zx.a(cde, CharacterState.Custom2, text);
				zx.a(cde, CharacterState.Custom3, text);
				zx.a(cde, CharacterState.Custom4, text);
				zx.a(cde, CharacterState.Custom5, text);
				if (A_0 != null && A_0.StartsWith("v_", StringComparison.OrdinalIgnoreCase))
				{
					zx.a(cde, CharacterState.Custom6, text, a_, a_2, false);
				}
				else
				{
					zx.a(cde, CharacterState.Custom6, text);
				}
				foreach (KeyValuePair<CharacterState, CharacterState> keyValuePair in cde.b)
				{
					zx.a[keyValuePair.Key] = zx.a[keyValuePair.Value];
				}
				return zx;
			}
		}
		return bz9.d();
	}

	// Token: 0x06005F61 RID: 24417 RVA: 0x00287B5C File Offset: 0x00285D5C
	public static cde e(string A_0)
	{
		cde result;
		if (A_0 != null)
		{
			bz9.b.TryGetValue(A_0, out result);
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06005F62 RID: 24418 RVA: 0x00287B88 File Offset: 0x00285D88
	public static string d(string A_0)
	{
		if (A_0 == "ak")
		{
			return "ra";
		}
		return A_0;
	}

	// Token: 0x06005F63 RID: 24419 RVA: 0x00287BA4 File Offset: 0x00285DA4
	private static void a(cde A_0, CharacterState A_1, int A_2, float A_3)
	{
		A_0.a[A_1.ToString()] = A_2;
		A_0.c[A_1] = new float?(A_3);
	}

	// Token: 0x06005F64 RID: 24420 RVA: 0x00287BD4 File Offset: 0x00285DD4
	private static void a(cde A_0, CharacterState A_1, CharacterState A_2)
	{
		A_0.b[A_1] = A_2;
	}

	// Token: 0x06005F65 RID: 24421 RVA: 0x00287BE8 File Offset: 0x00285DE8
	private static void a(cde A_0, CharacterState A_1 = CharacterState.Idle)
	{
		foreach (object obj in Enum.GetValues(typeof(CharacterState)))
		{
			CharacterState characterState = (CharacterState)obj;
			if (!A_0.a.ContainsKey(characterState.ToString()) && !A_0.b.ContainsKey(characterState))
			{
				bz9.a(A_0, characterState, A_1);
			}
		}
	}

	// Token: 0x06005F66 RID: 24422 RVA: 0x00287C84 File Offset: 0x00285E84
	private static zx d()
	{
		zx zx = new zx();
		zx.a[CharacterState.Attack1] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Attack2] = new am5("Unknown", 1, null);
		zx.a[CharacterState.CastingPsi] = new am5("Unknown", 1, null);
		zx.a[CharacterState.ChannelPsi] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Custom1] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Custom2] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Custom3] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Die] = new am5("Unknown", 1, null);
		zx.a[CharacterState.FinishPsi] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Idle] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Move] = new am5("Unknown", 1, null);
		zx.a[CharacterState.OperateShort] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Operating] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Throw] = new am5("Unknown", 1, null);
		zx.a[CharacterState.Stunned] = new am5("Unknown", 1, null);
		zx.a[CharacterState.LowerWeapon] = new am5("Unknown", 1, null);
		zx.a[CharacterState.RaiseWeapon] = new am5("Unknown", 1, null);
		return zx;
	}

	// Token: 0x06005F67 RID: 24423 RVA: 0x00287EC0 File Offset: 0x002860C0
	private static void c()
	{
		bz9.a = new Dictionary<CharacterState, string>();
		bz9.a[CharacterState.Attack1] = "a1";
		bz9.a[CharacterState.Attack2] = "a2";
		bz9.a[CharacterState.CastingPsi] = "caps";
		bz9.a[CharacterState.ChannelPsi] = "chps";
		bz9.a[CharacterState.FinishPsi] = "fips";
		bz9.a[CharacterState.Die] = "di";
		bz9.a[CharacterState.Idle] = "id";
		bz9.a[CharacterState.Move] = "mv";
		bz9.a[CharacterState.OperateShort] = "ops";
		bz9.a[CharacterState.Operating] = "opc";
		bz9.a[CharacterState.Throw] = "th";
		bz9.a[CharacterState.RaiseWeapon] = "r";
		bz9.a[CharacterState.LowerWeapon] = "l";
		bz9.a[CharacterState.ShieldBash] = "sb";
		bz9.a[CharacterState.Stunned] = "st";
		bz9.a[CharacterState.Custom1] = "c1";
		bz9.a[CharacterState.Custom2] = "c2";
		bz9.a[CharacterState.Custom3] = "c3";
		bz9.a[CharacterState.Custom4] = "c4";
		bz9.a[CharacterState.Custom5] = "c5";
		bz9.a[CharacterState.Custom6] = "c6";
	}

	// Token: 0x06005F68 RID: 24424 RVA: 0x00288034 File Offset: 0x00286234
	private static void b()
	{
	}

	// Token: 0x06005F69 RID: 24425 RVA: 0x0028803C File Offset: 0x0028623C
	private static void a()
	{
		bz9.b = new Dictionary<string, cde>();
		bz9.b[bln.a] = bz9.a("pl", Gender.Male, true, true, null, 0, null, false);
		bz9.b[bln.b] = bz9.a("pl_f", Gender.Female, true, true, null, 0, null, false);
		bz9.b[bln.d] = bz9.a(bln.d, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.e] = bz9.a(bln.e, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.f] = bz9.a(bln.f, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.g] = bz9.a(bln.g, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.h] = bz9.a(bln.h, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.i] = bz9.a(bln.i, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.j] = bz9.a(bln.j, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.k] = bz9.a(bln.k, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.l] = bz9.a(bln.l, Gender.Male, false, true, null, 0, new Dictionary<CharacterState, int>
		{
			{
				CharacterState.Custom1,
				14
			}
		}, false);
		bz9.b[bln.m] = bz9.a(bln.m, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.n] = bz9.a(bln.n, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.o] = bz9.a(bln.o, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.p] = bz9.a(bln.p, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.q] = bz9.a(bln.q, Gender.Male, false, true, null, 0, new Dictionary<CharacterState, int>
		{
			{
				CharacterState.Custom1,
				14
			}
		}, false);
		bz9.b[bln.r] = bz9.a(bln.r, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.s] = bz9.a(bln.s, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.t] = bz9.a(bln.t, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.u] = bz9.a(bln.u, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.v] = bz9.a(bln.v, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.w] = bz9.a(bln.w, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.x] = bz9.a(bln.x, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.y] = bz9.a(bln.y, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.z] = bz9.a(bln.z, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.aa] = bz9.a(bln.aa, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.ab] = bz9.a(bln.ab, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.ac] = bz9.a(bln.ac, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ad] = bz9.a(bln.ad, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ae] = bz9.a(bln.ae, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.af] = bz9.a(bln.af, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.ai] = bz9.a(bln.ai, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.aj] = bz9.a(bln.aj, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ak] = bz9.a(bln.ak, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.al] = bz9.a(bln.al, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.am] = bz9.a(bln.am, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.an] = bz9.a(bln.an, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ao] = bz9.a(bln.ao, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ap] = bz9.a(bln.ap, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.aq] = bz9.a(bln.aq, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.ar] = bz9.a("pl_mt", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.@as] = bz9.a(bln.@as, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.at] = bz9.a(bln.at, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.au] = bz9.a(bln.au, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.av] = bz9.a("pl_f_mt", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.aw] = bz9.a(bln.aw, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.ax] = bz9.a(bln.ax, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ay] = bz9.a(bln.ay, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.az] = bz9.a(bln.az, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.a0] = bz9.a(bln.a0, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.a1] = bz9.a(bln.a1, Gender.Male, false, true, null, 0, new Dictionary<CharacterState, int>
		{
			{
				CharacterState.Custom1,
				14
			}
		}, false);
		bz9.b[bln.a2] = bz9.a(bln.a2, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.a3] = bz9.a(bln.a3, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.a4] = bz9.a(bln.a4, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.a5] = bz9.a(bln.a5, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.a6] = bz9.a(bln.a6, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.a7] = bz9.a(bln.a7, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.a8] = bz9.a(bln.a8, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.a9] = bz9.a(bln.a9, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ba] = bz9.a("pl_cmd", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bb] = bz9.a(bln.bb, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.dl] = bz9.a(bln.dl, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.dm] = bz9.a(bln.dm, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.dn] = bz9.a(bln.dn, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.@do] = bz9.a(bln.@do, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.dp] = bz9.a(bln.dp, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.dq] = bz9.a(bln.dq, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.dr] = bz9.a(bln.dr, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.dd] = bz9.a(bln.dd, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.de] = bz9.a(bln.de, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.cn] = bz9.a("pl_bh", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.co] = bz9.a("pl_f_bh", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.bc] = bz9.a("pl_ri", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bd] = bz9.a("pl_ri_s", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.be] = bz9.a("pl_ri_c", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bf] = bz9.a("pl_ri_c_s", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bg] = bz9.a("pl_f_ri", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.bh] = bz9.a("pl_f_ri_s", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.bi] = bz9.a("pl_f_ri_c", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.bj] = bz9.a("pl_f_ri_c_s", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.bm] = bz9.a(bln.bm, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bn] = bz9.a(bln.bn, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bo] = bz9.a(bln.bo, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.br] = bz9.a(bln.br, Gender.Male, "FoundryWorker");
		bz9.b[bln.bs] = bz9.a(bln.bs, Gender.Male, "FoundryWorker");
		bz9.b[bln.bt] = bz9.a(bln.bt, Gender.Male, "FoundryWorker");
		bz9.b[bln.bu] = bz9.a(bln.bu, Gender.Male, "FoundryWorker");
		bz9.b[bln.bv] = bz9.a(bln.bv, Gender.Female, "FoundryWorker_Female");
		bz9.b[bln.cq] = bz9.a("pl_bls", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.cr] = bz9.a("pl_f_bls", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.bw] = bz9.a("pl_tch", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bx] = bz9.a("pl_f_tch", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.by] = bz9.a("pl_rb", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bz] = bz9.a("pl_f_rb", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.b2] = bz9.a(bln.b2, Gender.Male, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.b3] = bz9.a(bln.b3, Gender.Female, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.b0] = bz9.a(bln.b0, Gender.Female, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.b1] = bz9.a(bln.b1, Gender.Female, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.b4] = bz9.a(bln.b4, Gender.Male, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.b5] = bz9.a(bln.b5, Gender.Male, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.b6] = bz9.a(bln.b6, Gender.Male, false, true, "Human_Fat", -10, null, false);
		bz9.b[bln.b7] = bz9.a(bln.b7, Gender.Male, false, true, "Human_Fat", -10, null, false);
		bz9.b[bln.b8] = bz9.a(bln.b8, Gender.Female, false, true, "Human_Fat", -10, null, false);
		bz9.b[bln.b9] = bz9.a(bln.b9, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ca] = bz9.a(bln.ca, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.cb] = bz9.a(bln.cb, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bk] = bz9.a("pl_prbio", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bl] = bz9.a("pl_f_prbio", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.ce] = bz9.a("pl_tchnob", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.cg] = bz9.a("pl_f_tchnob", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.cf] = bz9.a("pl_tchsol", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ch] = bz9.a("pl_f_tchsol", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.cj] = bz9.a(bln.cj, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ck] = bz9.a(bln.ck, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.cl] = bz9.a(bln.cl, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.cm] = bz9.a(bln.cm, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.da] = bz9.a(bln.da, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.db] = bz9.a(bln.db, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.dc] = bz9.a(bln.dc, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.fr] = bz9.a(bln.fr, Gender.Male, false, true, null, 0, null, true);
		bz9.b[bln.cz] = bz9.a(bln.cz, Gender.Male, false, true, null, 0, null, true);
		bz9.b[bln.fs] = bz9.a(bln.fs, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ft] = bz9.a(bln.ft, Gender.Male, false, true, null, 0, new Dictionary<CharacterState, int>
		{
			{
				CharacterState.Custom1,
				8
			}
		}, false);
		bz9.b[bln.fq] = bz9.a(bln.fq, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.cp] = bz9.a(bln.cp, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.cs] = bz9.a(bln.cs, Gender.Male, false, true, "Human_Large", 5, null, false);
		bz9.b[bln.ct] = bz9.a(bln.ct, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.cu] = bz9.a(bln.cu, Gender.Male, false, true, null, 0, null, true);
		bz9.b[bln.cv] = bz9.a(bln.cv, Gender.Male, false, true, null, 0, null, true);
		bz9.b[bln.cw] = bz9.a(bln.cw, Gender.Male, false, true, null, 0, null, true);
		bz9.b[bln.cx] = bz9.a(bln.cx, Gender.Female, false, true, null, 0, null, true);
		bz9.b[bln.cy] = bz9.a(bln.cy, Gender.Female, false, true, null, 0, null, true);
		bz9.b[bln.c0] = bz9.a("pl_praec", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.c1] = bz9.a("pl_praet", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.c2] = bz9.a("pl_praem", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.c3] = bz9.a("pl_f_praec", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.c4] = bz9.a("pl_f_praet", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.c5] = bz9.a("pl_f_praem", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.c6] = bz9.a(bln.c6, Gender.Male, false, true, null, 0, null, true);
		bz9.b[bln.c7] = bz9.a(bln.c7, Gender.Male, false, true, null, 0, null, true);
		bz9.b[bln.c8] = bz9.a(bln.c8, Gender.Female, false, true, null, 0, null, true);
		bz9.b[bln.fv] = bz9.a(bln.fv, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.fw] = bz9.a(bln.fw, Gender.Male, false, true, null, -20, null, false);
		bz9.b[bln.fx] = bz9.a(bln.fx, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.fx].c[CharacterState.Custom1] = bz9.b[bln.fx].c[CharacterState.Idle];
		bz9.b[bln.fx].c[CharacterState.Custom2] = bz9.b[bln.fx].c[CharacterState.Idle];
		bz9.b[bln.fx].a[CharacterState.Custom1.ToString()] = 8;
		bz9.b[bln.fx].a[CharacterState.Custom2.ToString()] = 8;
		bz9.b[bln.fy] = bz9.a(bln.fy, Gender.Male, false, true, "Human_Large", 5, null, false);
		bz9.b[bln.fz] = bz9.a(bln.fz, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.@if] = bz9.a(bln.@if, Gender.Male, false, true, null, -20, null, false);
		bz9.b[bln.id] = bz9.a(bln.id, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.f0] = bz9.a(bln.f0, Gender.Male, false, true, "Human_Fat", -10, null, false);
		bz9.b[bln.f1] = bz9.a(bln.f1, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.f3] = bz9.a(bln.f3, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.f4] = bz9.a(bln.f4, Gender.Male, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.f5] = bz9.a(bln.f5, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.ha] = bz9.a("pl_xpbl_ras", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hb] = bz9.a("pl_xpbl_rao", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hc] = bz9.a("pl_xpbl_rac", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hd] = bz9.a(bln.hd, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.he] = bz9.a(bln.he, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hf] = bz9.a(bln.hf, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hg] = bz9.a(bln.hg, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hh] = bz9.a(bln.hh, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hi] = bz9.a(bln.hi, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hj] = bz9.a(bln.hj, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.hk] = bz9.a(bln.hk, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.hl] = bz9.a(bln.hl, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.hm] = bz9.a(bln.hm, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.hn] = bz9.a(bln.hn, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ho] = bz9.a(bln.ho, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.hp] = bz9.a(bln.hp, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hq] = bz9.a(bln.hq, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hs] = bz9.a(bln.hs, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hr] = bz9.a(bln.hr, Gender.Male, false, true, "Human_Large", 5, null, false);
		bz9.b[bln.@if] = bz9.a(bln.@if, Gender.Male, false, true, null, -20, null, false);
		bz9.b[bln.j0] = bz9.a("pl_xpbl_lps_c", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ig] = bz9.a(bln.ig, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ih] = bz9.a(bln.ih, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ht] = bz9.a("pl_xpbl_ags", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hu] = bz9.a(bln.hu, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hv] = bz9.a(bln.hv, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hw] = bz9.a("pl_f_xpbl_ags", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.hx] = bz9.a(bln.hx, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.hy] = bz9.a(bln.hy, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.h0] = bz9.a(bln.h0, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hz] = bz9.a(bln.hz, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.hz].c[CharacterState.Custom1] = bz9.b[bln.hz].c[CharacterState.Idle];
		bz9.b[bln.hz].c[CharacterState.Custom2] = bz9.b[bln.hz].c[CharacterState.Idle];
		bz9.b[bln.hz].a[CharacterState.Custom1.ToString()] = 8;
		bz9.b[bln.hz].a[CharacterState.Custom2.ToString()] = 8;
		bz9.b[bln.h1] = bz9.a("pl_xpbl_prns", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.h2] = bz9.a("pl_f_xpbl_prns", Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.h3] = bz9.a(bln.h3, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.h4] = bz9.a(bln.h4, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.h5] = bz9.a(bln.h5, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.h6] = bz9.a(bln.h6, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.h7] = bz9.a(bln.h7, Gender.Female, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.h8] = bz9.a(bln.h8, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.h9] = bz9.a(bln.h9, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ia] = bz9.a(bln.ia, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ic] = bz9.a(bln.ic, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ib] = bz9.a(bln.ib, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ib].c[CharacterState.Custom1] = bz9.b[bln.ib].c[CharacterState.Idle];
		bz9.b[bln.ib].c[CharacterState.Custom2] = bz9.b[bln.ib].c[CharacterState.Idle];
		bz9.b[bln.ib].c[CharacterState.Custom3] = bz9.b[bln.ib].c[CharacterState.Idle];
		bz9.b[bln.ib].c[CharacterState.Custom4] = bz9.b[bln.ib].c[CharacterState.Idle];
		bz9.b[bln.ib].a[CharacterState.Custom1.ToString()] = 8;
		bz9.b[bln.ib].a[CharacterState.Custom2.ToString()] = 8;
		bz9.b[bln.ib].a[CharacterState.Custom3.ToString()] = 8;
		bz9.b[bln.ib].a[CharacterState.Custom4.ToString()] = 8;
		bz9.b[bln.ip] = bz9.a(bln.ip, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.iq] = bz9.a(bln.iq, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ir] = bz9.a(bln.ir, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.@is] = bz9.a(bln.@is, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.it] = bz9.a(bln.it, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.iu] = bz9.a(bln.iu, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.iv] = bz9.a(bln.iv, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.iw] = bz9.a(bln.iw, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ix] = bz9.a(bln.ix, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.iy] = bz9.a(bln.iy, 10);
		bz9.b[bln.iz] = bz9.a(bln.iz, 10);
		bz9.b[bln.i0] = bz9.a(bln.i0, 8);
		bz9.b[bln.i1] = bz9.a(bln.i1, 8);
		bz9.b[bln.i2] = bz9.a(bln.i2, 8);
		bz9.b[bln.i3] = bz9.a(bln.i3, Gender.Male, false, true, "Human_Large", 0, null, false);
		bz9.b[bln.i4] = bz9.a(bln.i4, Gender.Male, false, true, "Xpbl_SavageChieftan", 0, null, false);
		bz9.b[bln.i5] = bz9.a(bln.i5, Gender.Male, false, true, "Xpbl_SavageChieftan", 0, null, false);
		bz9.b[bln.i9] = bz9.a(bln.i9, Gender.Male, false, true, "Human_Large", 0, null, false);
		bz9.b[bln.ja] = bz9.a(bln.ja, Gender.Male, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.jb] = bz9.a(bln.jb, Gender.Male, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.jc] = bz9.a(bln.jc, Gender.Male, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.jd] = bz9.a(bln.jd, Gender.Female, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.je] = bz9.a(bln.je, Gender.Female, false, true, "Human_Old", 0, null, false);
		bz9.b[bln.jf] = bz9.a(bln.jf, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.jg] = bz9.a(bln.jg, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.jh] = bz9.a(bln.jh, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.ji] = bz9.a(bln.ji, Gender.Female, false, true, null, 0, null, false);
		bz9.b[bln.jm] = bz9.a(bln.jm, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.l6] = bz9.a(bln.l6, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.l7] = bz9.a(bln.l7, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.l8] = bz9.a("pl_xphw_exodoc", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.l9] = bz9.a("pl_xphw_exooff", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.ma] = bz9.a("pl_xphw_exopsi", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.mb] = bz9.a("pl_xphw_exosol", Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.mc] = bz9.a(bln.mc, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.md] = bz9.a(bln.md, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.md].a[CharacterState.Custom1.ToString()] = 16;
		bz9.b[bln.md].a[CharacterState.Custom2.ToString()] = 8;
		bz9.b[bln.md].a[CharacterState.Custom3.ToString()] = 8;
		bz9.b[bln.md].c[CharacterState.Custom1] = bz9.b[bln.md].c[CharacterState.Idle];
		bz9.b[bln.md].c[CharacterState.Custom2] = bz9.b[bln.md].c[CharacterState.Idle];
		bz9.b[bln.md].c[CharacterState.Custom3] = bz9.b[bln.md].c[CharacterState.Idle];
		bz9.b[bln.j1] = bz9.a(bln.j1, Gender.Male, false, false);
		bz9.b[bln.j2] = bz9.a(bln.j2, Gender.Male, false, false);
		bz9.b[bln.kh] = bz9.a(bln.kh, Gender.Female, false, false);
		bz9.b[bln.j3] = bz9.a(bln.j3, Gender.Male, false, false);
		bz9.b[bln.ki] = bz9.a(bln.ki, Gender.Female, false, false);
		bz9.b[bln.j4] = bz9.a(bln.j4, Gender.Male, false, false);
		bz9.b[bln.kj] = bz9.a(bln.kj, Gender.Female, false, false);
		bz9.b[bln.j5] = bz9.a(bln.j5, Gender.Male, false, false);
		bz9.b[bln.j5].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.kk] = bz9.a(bln.kk, Gender.Female, false, false);
		bz9.b[bln.kk].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.j6] = bz9.a(bln.j6, Gender.Male, false, false);
		bz9.b[bln.j6].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.kl] = bz9.a(bln.kl, Gender.Female, false, false);
		bz9.b[bln.kl].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.j8] = bz9.a(bln.j8, Gender.Male, false, false);
		bz9.b[bln.j8].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.kn] = bz9.a(bln.kn, Gender.Female, false, false);
		bz9.b[bln.kn].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.j7] = bz9.a(bln.j7, Gender.Male, false, false);
		bz9.b[bln.j7].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.km] = bz9.a(bln.km, Gender.Female, false, false);
		bz9.b[bln.km].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.j9] = bz9.a(bln.j9, Gender.Male, true, false);
		bz9.b[bln.ko] = bz9.a(bln.ko, Gender.Female, true, false);
		bz9.b[bln.ka] = bz9.a(bln.ka, Gender.Male, false, false);
		bz9.b[bln.kp] = bz9.a(bln.kp, Gender.Female, false, false);
		bz9.b[bln.kb] = bz9.a(bln.kb, Gender.Male, false, false);
		bz9.b[bln.kq] = bz9.a(bln.kq, Gender.Female, false, false);
		bz9.b[bln.kc] = bz9.a(bln.kc, Gender.Male, true, false);
		bz9.b[bln.kr] = bz9.a(bln.kr, Gender.Female, true, false);
		bz9.b[bln.lb] = bz9.a(bln.lb, Gender.Male, true, false);
		bz9.b[bln.lc] = bz9.a(bln.lc, Gender.Female, true, false);
		bz9.b[bln.kd] = bz9.a(bln.kd, Gender.Male, true, false);
		bz9.b[bln.kd].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.kd].a[CharacterState.Custom5.ToString()] = 4;
		bz9.b[bln.ks] = bz9.a(bln.ks, Gender.Female, true, false);
		bz9.b[bln.ks].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.ks].a[CharacterState.Custom5.ToString()] = 4;
		bz9.b[bln.ke] = bz9.a(bln.ke, Gender.Male, true, true);
		bz9.b[bln.ke].a[CharacterState.Custom4.ToString()] = 10;
		bz9.b[bln.kt] = bz9.a(bln.kt, Gender.Female, true, true);
		bz9.b[bln.kt].a[CharacterState.Custom4.ToString()] = 10;
		bz9.b[bln.kf] = bz9.a(bln.kf, Gender.Male, true, true);
		bz9.b[bln.ku] = bz9.a(bln.ku, Gender.Female, true, true);
		bz9.b[bln.kg] = bz9.a(bln.kg, Gender.Male, false, false);
		bz9.b[bln.kg].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.kg].a[CharacterState.Custom5.ToString()] = 4;
		bz9.b[bln.kv] = bz9.a(bln.kv, Gender.Female, false, false);
		bz9.b[bln.kv].a[CharacterState.Custom4.ToString()] = 4;
		bz9.b[bln.kv].a[CharacterState.Custom5.ToString()] = 4;
		bz9.b[bln.kw] = bz9.a(bln.kw, Gender.Male, false, false);
		bz9.b[bln.kx] = bz9.a(bln.kx, Gender.Male, false, false);
		bz9.b[bln.ky] = bz9.a(bln.ky, Gender.Male, false, false);
		bz9.b[bln.kz] = bz9.a(bln.kz, Gender.Male, true, false);
		bz9.b[bln.k0] = bz9.a(bln.k0, Gender.Male, false, false);
		bz9.b[bln.k1] = bz9.a(bln.k1, Gender.Male, false, false);
		bz9.b[bln.k2] = bz9.a(bln.k2, Gender.Female, false, false);
		bz9.b[bln.k3] = bz9.a(bln.k3, Gender.Female, false, false);
		bz9.b[bln.k4] = bz9.a(bln.k4, Gender.Female, false, false);
		bz9.b[bln.k5] = bz9.a(bln.k5, Gender.Male, true, false);
		bz9.b[bln.k6] = bz9.a(bln.k6, Gender.Male, true, false);
		bz9.b[bln.k7] = bz9.a(bln.k7, Gender.Male, true, false);
		bz9.b[bln.k8] = bz9.a(bln.k8, Gender.Male, true, false);
		bz9.b[bln.k9] = bz9.a(bln.k9, Gender.Female, true, false);
		bz9.b[bln.la] = bz9.a(bln.la, Gender.Female, true, false);
		bz9.b[bln.ld] = bz9.a(bln.ld, Gender.Female, false, false);
		bz9.b[bln.le] = bz9.a(bln.le, Gender.Female, false, false);
		bz9.b[bln.lf] = bz9.a(bln.lf, Gender.Female, false, false);
		bz9.b[bln.lg] = bz9.a(bln.lg, Gender.Female, false, false);
		bz9.b[bln.lh] = bz9.a(bln.lh, Gender.Female, false, false);
		bz9.b[bln.li] = bz9.a(bln.li, Gender.Female, false, false);
		bz9.b[bln.lj] = bz9.a(bln.lj, Gender.Male, false, false);
		bz9.b[bln.lk] = bz9.a(bln.lk, Gender.Male, false, false);
		bz9.b[bln.ll] = bz9.a(bln.ll, Gender.Male, false, false);
		bz9.b[bln.lm] = bz9.a(bln.lm, Gender.Male, false, false);
		bz9.b[bln.ln] = bz9.a(bln.ln, Gender.Male, false, false);
		bz9.b[bln.lo] = bz9.a(bln.lo, Gender.Male, false, false);
		bz9.b[bln.lp] = bz9.a(bln.lp, Gender.Male, false, false);
		bz9.b[bln.lq] = bz9.a(bln.lq, Gender.Male, false, false);
		bz9.b[bln.lr] = bz9.a(bln.lr, Gender.Male, false, false);
		bz9.b[bln.ls] = bz9.a(bln.ls, Gender.Male, false, false);
		bz9.b[bln.lt] = bz9.a(bln.lt, Gender.Male, false, false);
		bz9.b[bln.lu] = bz9.a(bln.lu, Gender.Male, false, false);
		bz9.b[bln.lv] = bz9.a(bln.lv, Gender.Male, false, false);
		bz9.b[bln.lw] = bz9.a(bln.lw, Gender.Male, false, false);
		bz9.b[bln.lx] = bz9.a(bln.lx, Gender.Male, false, false);
		bz9.b[bln.ly] = bz9.a(bln.ly, Gender.Male, false, false);
		bz9.b[bln.lz] = bz9.a(bln.lz, Gender.Male, false, false);
		bz9.b[bln.l0] = bz9.a(bln.l0, Gender.Male, false, false);
		bz9.b[bln.l1] = bz9.a(bln.l1, Gender.Female, false, false);
		bz9.b[bln.bp] = bz9.a(bln.bp, Gender.Male, false, true, "Dude", 0, null, false);
		bz9.b[bln.bp].a[CharacterState.Custom1.ToString()] = 19;
		bz9.b[bln.bp].a[CharacterState.Custom2.ToString()] = 14;
		bz9.b[bln.bp].c[CharacterState.Custom1] = bz9.b[bln.bp].c[CharacterState.Idle];
		bz9.b[bln.bp].c[CharacterState.Custom2] = bz9.b[bln.bp].c[CharacterState.Idle];
		bz9.b[bln.bq] = bz9.a(bln.bq, Gender.Male, false, true, null, 0, null, false);
		bz9.b[bln.bq].a[CharacterState.Attack1.ToString() + "ak"] = 3;
		bz9.b[bln.bq].a[CharacterState.RaiseWeapon.ToString() + "ak"] = 5;
		bz9.b[bln.bq].a[CharacterState.LowerWeapon.ToString() + "ak"] = 5;
		cde cde = bz9.a(bln.cc, Gender.Male, false, true, "RahmUmbra", 5, null, false);
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom3.ToString()] = 7;
		cde.a[CharacterState.Custom4.ToString()] = 7;
		bz9.b[bln.cc] = cde;
		cde = bz9.a(bln.cd, Gender.Male, false, true, "Tanner", 10, null, false);
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 6;
		cde.a[CharacterState.Custom1.ToString()] = 10;
		bz9.b[bln.cd] = cde;
		cde = bz9.a(bln.ci, Gender.Male, false, true, "TchortistJuggernaut", 8, null, false);
		cde.a[CharacterState.Attack2.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 12;
		cde.b[CharacterState.FinishPsi] = CharacterState.Custom1;
		bz9.b[bln.ci] = cde;
		cde = bz9.a(bln.ii, Gender.Male, false, false, null, 0, null, false);
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.a[CharacterState.FinishPsi.ToString()] = 6;
		bz9.b[bln.ii] = cde;
		foreach (string text in new string[]
		{
			bln.ag,
			bln.ah
		})
		{
			cde cde2 = bz9.a(text, Gender.Male, false, true, null, 0, null, false);
			cde2.c[CharacterState.Custom1] = new float?(1f);
			cde2.a[CharacterState.Custom1.ToString()] = 3;
			bz9.b[text] = cde2;
		}
		cde = bz9.a(bln.ie, Gender.Male, false, true, null, 0, null, false);
		cde.a[CharacterState.Attack1.ToString()] = 5;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.Operating] = CharacterState.Idle;
		bz9.b[bln.ie] = cde;
		cde = bz9.a(bln.c9, Gender.Male, false, true, null, 0, null, false);
		cde.a[CharacterState.Custom1.ToString()] = 10;
		bz9.b[bln.c9] = cde;
		cde = bz9.a(bln.fu, Gender.Male, false, true, "Human_Old", 0, null, false);
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 8;
		cde.a[CharacterState.Custom3.ToString()] = 19;
		bz9.b[bln.fu] = cde;
		bz9.b[bln.ex] = bz9.b("mh1", "MutatedHuman1");
		bz9.b[bln.ey] = bz9.b("mh2", "MutatedHuman2");
		bz9.b[bln.ez] = bz9.b("mh3", "MutatedHuman3");
		bz9.b[bln.e0] = bz9.b("mhth", "MutatedHumanTwoHeaded");
		bz9.b["plmut"] = bz9.a("plmut", "MutatedPlayer");
		bz9.b["plmutf"] = bz9.a("plmutf", "MutatedPlayer");
		bz9.b["plmuti"] = bz9.a("plmuti", "MutatedPlayer");
		bz9.b["plmutfi"] = bz9.a("plmutfi", "MutatedPlayer");
		foreach (string text2 in new string[]
		{
			bln.e1,
			bln.e2,
			bln.e3
		})
		{
			foreach (string text3 in new string[]
			{
				"",
				"ac",
				"acl",
				"bob",
				"bobl",
				"eb",
				"rc",
				"crc",
				"pb",
				"pbl",
				"nb"
			})
			{
				string text4 = text2;
				if (!string.IsNullOrEmpty(text3))
				{
					text4 = text2 + "_" + text3;
				}
				cde = new cde();
				cde.d = text4;
				cde.e = "HunchbackMutant";
				cde.k = 105;
				cde.l = new float?(0.13f);
				cde.f = false;
				cde.g = false;
				cde.c[CharacterState.Idle] = new float?(1f);
				cde.c[CharacterState.Die] = new float?(1f);
				cde.c[CharacterState.Move] = new float?(1f);
				cde.c[CharacterState.Attack1] = new float?(1f);
				cde.c[CharacterState.Attack2] = new float?(1f);
				cde.c[CharacterState.OperateShort] = new float?(1f);
				cde.c[CharacterState.Operating] = new float?(1f);
				cde.c[CharacterState.Throw] = new float?(1f);
				cde.c[CharacterState.Stunned] = new float?(1f);
				cde.c[CharacterState.FinishPsi] = new float?(1f);
				cde.c[CharacterState.Custom3] = new float?(1f);
				cde.a[CharacterState.Idle.ToString()] = 8;
				cde.a[CharacterState.Die.ToString()] = 9;
				cde.a[CharacterState.Move.ToString()] = 8;
				cde.a[CharacterState.Attack1.ToString()] = 9;
				cde.a[CharacterState.Attack2.ToString()] = 9;
				cde.a[CharacterState.OperateShort.ToString()] = 5;
				cde.a[CharacterState.Operating.ToString()] = 8;
				cde.a[CharacterState.Throw.ToString()] = 7;
				cde.a[CharacterState.Stunned.ToString()] = 8;
				cde.a[CharacterState.FinishPsi.ToString()] = 9;
				cde.a[CharacterState.Custom3.ToString()] = 9;
				cde.b[CharacterState.CastingPsi] = CharacterState.Operating;
				cde.b[CharacterState.ChannelPsi] = CharacterState.Operating;
				if (!string.IsNullOrEmpty(text3))
				{
					cde.b[CharacterState.Attack2] = CharacterState.Attack1;
				}
				bz9.b[text4] = cde;
			}
		}
		cde = new cde();
		cde.f = false;
		cde.g = false;
		cde.d = "dg";
		cde.e = "Dog";
		cde.k = 65;
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Move] = new float?(1f);
		cde.c[CharacterState.Custom1] = new float?(1f);
		cde.c[CharacterState.Custom2] = new float?(1f);
		cde.c[CharacterState.Custom3] = new float?(1f);
		cde.c[CharacterState.Custom4] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.Stunned] = new float?(1f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 7;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom3.ToString()] = 6;
		cde.a[CharacterState.Custom4.ToString()] = 6;
		cde.b[CharacterState.Operating] = CharacterState.Custom2;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Custom4;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Custom3;
		bz9.b[bln.ds] = cde;
		cde = new cde();
		cde.k = 65;
		cde.f = false;
		cde.g = false;
		cde.d = "mdg";
		cde.e = "Dog";
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Move] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.FinishPsi] = new float?(1f);
		cde.c[CharacterState.Stunned] = new float?(1f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 10;
		cde.b[CharacterState.Operating] = CharacterState.Idle;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Idle;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		cde.b[CharacterState.Throw] = CharacterState.FinishPsi;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		bz9.b[bln.dt] = cde;
		cde = bz9.c(1f);
		cde.d = "rh";
		cde.e = "Rathound";
		cde.k = 65;
		bz9.b[bln.du] = cde;
		cde = bz9.c(1.2f);
		cde.d = "rh_a";
		cde.e = "RathoundAlpha";
		cde.k = 70;
		bz9.b[bln.dv] = cde;
		cde = bz9.c(1.2f);
		cde.d = "rh_aug";
		cde.e = "RathoundAlpha";
		cde.k = 70;
		bz9.b[bln.dw] = cde;
		cde = bz9.c(1.4f);
		cde.d = "rh_an";
		cde.e = "Rathound_Ancient";
		cde.k = 85;
		bz9.b[bln.dx] = cde;
		cde = new cde();
		cde.d = "ch";
		cde.e = "CaveHopper";
		cde.k = 45;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(0.6f);
		cde.c[CharacterState.Die] = new float?(0.6f);
		cde.c[CharacterState.Move] = new float?(0.6f);
		cde.c[CharacterState.Attack1] = new float?(0.65f);
		cde.c[CharacterState.Attack2] = new float?(0.65f);
		cde.c[CharacterState.Stunned] = new float?(0.6f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 6;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.b[CharacterState.Operating] = CharacterState.Attack2;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack2;
		cde.b[CharacterState.FinishPsi] = CharacterState.Attack1;
		bz9.b[bln.dy] = cde;
		cde = new cde();
		cde.d = "mc";
		cde.e = "MoleCricket";
		cde.k = 45;
		cde.l = new float?(0.1f);
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(0.4f);
		cde.c[CharacterState.Die] = new float?(0.4f);
		cde.c[CharacterState.Move] = new float?(0.4f);
		cde.c[CharacterState.Attack1] = new float?(0.4f);
		cde.c[CharacterState.Stunned] = new float?(0.4f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.b[CharacterState.Operating] = CharacterState.Attack1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.FinishPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.dz] = cde;
		cde = bz9.c(bln.fg);
		bz9.b[bln.fg] = cde;
		cde = bz9.c(bln.fh);
		bz9.b[bln.fh] = cde;
		cde = bz9.c(bln.fi);
		bz9.b[bln.fi] = cde;
		cde = new cde();
		cde.d = "bur";
		cde.e = "burrower";
		cde.k = 75;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.3f);
		cde.c[CharacterState.Attack1] = new float?(1.35f);
		cde.c[CharacterState.RaiseWeapon] = new float?(1.35f);
		cde.c[CharacterState.LowerWeapon] = new float?(1.35f);
		cde.c[CharacterState.Stunned] = new float?(1.25f);
		cde.c[CharacterState.Custom1] = new float?(1.35f);
		cde.c[CharacterState.Custom2] = new float?(1.25f);
		cde.c[CharacterState.Custom3] = new float?(1.25f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 4;
		cde.a[CharacterState.RaiseWeapon.ToString()] = 5;
		cde.a[CharacterState.LowerWeapon.ToString()] = 5;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 5;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.a[CharacterState.Custom3.ToString()] = 8;
		cde.b[CharacterState.OperateShort] = CharacterState.Custom2;
		cde.b[CharacterState.Operating] = CharacterState.Custom3;
		cde.b[CharacterState.CastingPsi] = CharacterState.Die;
		bz9.b[bln.d0] = cde;
		cde = new cde();
		cde.d = "burw";
		cde.e = "burrowerWarrior";
		cde.k = 85;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.3f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.35f);
		cde.c[CharacterState.Attack2] = new float?(1.35f);
		cde.c[CharacterState.Stunned] = new float?(1.25f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Attack2.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 6;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		bz9.b[bln.d1] = cde;
		cde = new cde();
		cde.d = "sp";
		cde.e = "spawn";
		cde.k = 35;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(0.5f);
		cde.c[CharacterState.Stunned] = new float?(0.5f);
		cde.c[CharacterState.Die] = new float?(0.5f);
		cde.c[CharacterState.Move] = new float?(0.5f);
		cde.c[CharacterState.Attack1] = new float?(0.5f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.d2] = cde;
		cde = new cde();
		cde.d = "glrv";
		cde.e = "GiantLarva";
		cde.k = 50;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 11;
		cde.a[CharacterState.Move.ToString()] = 7;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Die;
		bz9.b[bln.ep] = cde;
		cde = new cde();
		cde.d = "dw";
		cde.e = "DeepWorm";
		cde.k = 140;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 11;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Attack2.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 6;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.a[CharacterState.Custom3.ToString()] = 11;
		cde.b[CharacterState.Move] = CharacterState.Idle;
		bz9.b[bln.eq] = cde;
		cde = new cde();
		cde.d = "bdw";
		cde.e = "BurrowedDeepWorm";
		cde.k = 50;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 13;
		cde.b[CharacterState.Attack1] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Idle;
		cde.b[CharacterState.Die] = CharacterState.Idle;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		cde.b[CharacterState.OperateShort] = CharacterState.Idle;
		cde.b[CharacterState.Operating] = CharacterState.Idle;
		bz9.b[bln.er] = cde;
		cde = new cde();
		cde.d = "psibt";
		cde.e = "PsiBeetle";
		cde.k = 50;
		cde.f = false;
		cde.g = true;
		cde.c[CharacterState.Idle] = new float?(1.05f);
		cde.c[CharacterState.Custom1] = new float?(1.05f);
		cde.c[CharacterState.Custom2] = new float?(1.05f);
		cde.c[CharacterState.CastingPsi] = new float?(1.05f);
		cde.c[CharacterState.Die] = new float?(1.05f);
		cde.c[CharacterState.Move] = new float?(1.1f);
		cde.c[CharacterState.FinishPsi] = new float?(1.15f);
		cde.c[CharacterState.Attack1] = new float?(1.15f);
		cde.c[CharacterState.Attack2] = new float?(1.15f);
		cde.c[CharacterState.Stunned] = new float?(1.05f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 4;
		cde.a[CharacterState.Custom2.ToString()] = 3;
		cde.a[CharacterState.Attack1.ToString() + an3.a] = 8;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.CastingPsi;
		bz9.b[bln.d3] = cde;
		cde = new cde();
		cde.d = "psibtr";
		cde.e = "PsiBeetleRed";
		cde.k = 60;
		cde.f = false;
		cde.g = true;
		cde.c[CharacterState.Idle] = new float?(1.15f);
		cde.c[CharacterState.Custom1] = new float?(1.15f);
		cde.c[CharacterState.Custom2] = new float?(1.15f);
		cde.c[CharacterState.CastingPsi] = new float?(1.15f);
		cde.c[CharacterState.Die] = new float?(1.15f);
		cde.c[CharacterState.Move] = new float?(1.2f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.25f);
		cde.c[CharacterState.Attack2] = new float?(1.25f);
		cde.c[CharacterState.Stunned] = new float?(1.15f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 4;
		cde.a[CharacterState.Custom2.ToString()] = 3;
		cde.a[CharacterState.Attack1.ToString() + an3.a] = 8;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.CastingPsi;
		bz9.b[bln.d4] = cde;
		cde = new cde();
		cde.d = "psibtg";
		cde.e = "GreaterPsiBeetle";
		cde.k = 72;
		cde.f = false;
		cde.g = true;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Custom1] = new float?(1.25f);
		cde.c[CharacterState.Custom2] = new float?(1.25f);
		cde.c[CharacterState.CastingPsi] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.25f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.25f);
		cde.c[CharacterState.Attack2] = new float?(1.25f);
		cde.c[CharacterState.Stunned] = new float?(1.25f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 4;
		cde.a[CharacterState.Custom2.ToString()] = 3;
		cde.a[CharacterState.Attack1.ToString() + an3.a] = 8;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.CastingPsi;
		bz9.b[bln.d5] = cde;
		cde = new cde();
		cde.d = "psibty";
		cde.e = "PsiBeetle";
		cde.k = 50;
		cde.f = false;
		cde.g = true;
		cde.c[CharacterState.Idle] = new float?(0.9f);
		cde.c[CharacterState.Custom1] = new float?(0.9f);
		cde.c[CharacterState.Custom2] = new float?(0.9f);
		cde.c[CharacterState.CastingPsi] = new float?(0.9f);
		cde.c[CharacterState.Die] = new float?(0.9f);
		cde.c[CharacterState.Move] = new float?(0.9f);
		cde.c[CharacterState.FinishPsi] = new float?(0.9f);
		cde.c[CharacterState.Attack1] = new float?(0.9f);
		cde.c[CharacterState.Attack2] = new float?(0.9f);
		cde.c[CharacterState.Stunned] = new float?(0.9f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 4;
		cde.a[CharacterState.Custom2.ToString()] = 3;
		cde.a[CharacterState.Attack1.ToString() + an3.a] = 8;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.CastingPsi;
		bz9.b[bln.d6] = cde;
		cde = new cde();
		cde.d = "crw";
		cde.e = "crawler";
		cde.j = new Point(0, 80);
		cde.k = 75;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.25f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.35f);
		cde.c[CharacterState.Stunned] = new float?(1.25f);
		cde.c[CharacterState.Custom1] = new float?(1.1f);
		cde.c[CharacterState.Custom2] = new float?(1.1f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 10;
		cde.a[CharacterState.Custom2.ToString()] = 11;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.Operating] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.d7] = cde;
		cde = new cde();
		cde.d = "crwg";
		cde.e = "greaterCrawler";
		cde.j = new Point(0, 80);
		cde.k = 75;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.15f);
		cde.c[CharacterState.Die] = new float?(1.15f);
		cde.c[CharacterState.Move] = new float?(1.15f);
		cde.c[CharacterState.FinishPsi] = new float?(1.15f);
		cde.c[CharacterState.Attack1] = new float?(1.15f);
		cde.c[CharacterState.Stunned] = new float?(1.15f);
		cde.c[CharacterState.Custom1] = new float?(1.15f);
		cde.c[CharacterState.Custom2] = new float?(1.15f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 10;
		cde.a[CharacterState.Custom2.ToString()] = 11;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.Operating] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.d8] = cde;
		cde = new cde();
		cde.d = "crwb";
		cde.e = "black_crawler";
		cde.j = new Point(0, 90);
		cde.k = 90;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.25f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.35f);
		cde.c[CharacterState.Stunned] = new float?(1.25f);
		cde.c[CharacterState.Custom1] = new float?(1.1f);
		cde.c[CharacterState.Custom2] = new float?(1.1f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 9;
		cde.a[CharacterState.Custom2.ToString()] = 10;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.Operating] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		bz9.b[bln.d9] = cde;
		cde = new cde();
		cde.d = "sph";
		cde.e = "siphoner";
		cde.k = 75;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Stunned] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.25f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.25f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.ChannelPsi] = new float?(1.25f);
		cde.c[CharacterState.Custom1] = new float?(1.25f);
		cde.c[CharacterState.Custom2] = new float?(1.25f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 7;
		cde.a[CharacterState.ChannelPsi.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 4;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.ea] = cde;
		cde = new cde();
		cde.d = "csp";
		cde.e = "CoilSpider";
		cde.k = 90;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Move] = new float?(1f);
		cde.c[CharacterState.FinishPsi] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.FinishPsi] = new float?(1f);
		cde.c[CharacterState.ChannelPsi] = new float?(1f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.ChannelPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Operating.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Custom2.ToString()] = 11;
		cde.b[CharacterState.CastingPsi] = CharacterState.ChannelPsi;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		bz9.b[bln.eb] = cde;
		cde = new cde();
		cde.d = "cspg";
		cde.e = "GreaterCoilSpider";
		cde.k = 110;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Move] = new float?(1f);
		cde.c[CharacterState.FinishPsi] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.FinishPsi] = new float?(1f);
		cde.c[CharacterState.ChannelPsi] = new float?(1f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.ChannelPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Operating.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Custom2.ToString()] = 11;
		cde.b[CharacterState.CastingPsi] = CharacterState.ChannelPsi;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		bz9.b[bln.ec] = cde;
		cde = new cde();
		cde.d = "dv";
		cde.e = "Devourer";
		cde.k = 85;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Move] = new float?(1f);
		cde.c[CharacterState.Stunned] = new float?(1f);
		cde.c[CharacterState.FinishPsi] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.Attack2] = new float?(1f);
		cde.c[CharacterState.Custom1] = new float?(1f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Attack2.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 10;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Custom1.ToString()] = 10;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		bz9.b[bln.el] = cde;
		cde = new cde();
		cde.d = "sw";
		cde.e = "Sower";
		cde.k = 70;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.Move] = new float?(1f);
		cde.c[CharacterState.Stunned] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Custom1] = new float?(1f);
		cde.c[CharacterState.Custom2] = new float?(1f);
		cde.c[CharacterState.Custom3] = new float?(1f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Custom1.ToString()] = 11;
		cde.a[CharacterState.Custom2.ToString()] = 11;
		cde.a[CharacterState.Custom3.ToString()] = 10;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.FinishPsi] = CharacterState.Custom1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Custom2;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		bz9.b[bln.em] = cde;
		cde = new cde();
		cde.d = "tt";
		cde.e = "TchortTentacle";
		cde.k = 90;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 12;
		cde.a[CharacterState.Attack1.ToString()] = 15;
		cde.a[CharacterState.Attack2.ToString()] = 11;
		cde.a[CharacterState.Custom1.ToString()] = 7;
		cde.a[CharacterState.Die.ToString()] = 7;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		bz9.b[bln.es] = cde;
		cde = new cde();
		cde.d = "sc";
		cde.e = "Scanner";
		cde.k = 70;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(0.8f);
		cde.c[CharacterState.Move] = new float?(0.8f);
		cde.c[CharacterState.Attack1] = new float?(0.8f);
		cde.c[CharacterState.Attack2] = new float?(0.8f);
		cde.c[CharacterState.CastingPsi] = new float?(0.8f);
		cde.c[CharacterState.ChannelPsi] = new float?(0.8f);
		cde.c[CharacterState.Die] = new float?(0.8f);
		cde.c[CharacterState.FinishPsi] = new float?(0.8f);
		cde.c[CharacterState.Operating] = new float?(0.8f);
		cde.c[CharacterState.OperateShort] = new float?(0.8f);
		cde.c[CharacterState.Stunned] = new float?(0.8f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 6;
		cde.a[CharacterState.CastingPsi.ToString()] = 7;
		cde.a[CharacterState.ChannelPsi.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Operating.ToString()] = 6;
		cde.a[CharacterState.OperateShort.ToString()] = 3;
		cde.a[CharacterState.Stunned.ToString()] = 3;
		bz9.b[bln.en] = cde;
		cde = new cde();
		cde.d = "cs";
		cde.e = "Cuttlesnail";
		cde.k = 55;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 10;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Move.ToString()] = 4;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 11;
		cde.a[CharacterState.FinishPsi.ToString()] = 9;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Die;
		bz9.b[bln.eo] = cde;
		cde = new cde();
		cde.d = "shc";
		cde.e = "ShroomlingChomper";
		cde.k = 95;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 12;
		cde.a[CharacterState.Custom1.ToString()] = 1;
		cde.a[CharacterState.Custom2.ToString()] = 5;
		cde.a[CharacterState.Custom3.ToString()] = 5;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.FinishPsi] = CharacterState.Attack1;
		bz9.b[bln.eu] = cde;
		cde = new cde();
		cde.d = "shs";
		cde.e = "ShroomlingSpitter";
		cde.k = 95;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 12;
		cde.a[CharacterState.Custom1.ToString()] = 1;
		cde.a[CharacterState.Custom2.ToString()] = 5;
		cde.a[CharacterState.Custom3.ToString()] = 5;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.ev] = cde;
		cde = new cde();
		cde.d = "arch";
		cde.e = "Archon";
		cde.k = 110;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 9;
		cde.a[CharacterState.Attack2.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.CastingPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		bz9.b[bln.ew] = cde;
		foreach (string text5 in new string[]
		{
			bln.e4,
			bln.e5
		})
		{
			cde = new cde();
			cde.d = text5;
			cde.e = "Turret1";
			cde.k = 95;
			cde.f = false;
			cde.g = false;
			cde.a[CharacterState.Idle.ToString()] = 1;
			cde.a[CharacterState.Die.ToString()] = 9;
			cde.a[CharacterState.Attack1.ToString()] = 4;
			cde.a[CharacterState.Custom1.ToString()] = 1;
			cde.a[CharacterState.Custom2.ToString()] = 4;
			cde.a[CharacterState.Custom3.ToString()] = 4;
			cde.c[CharacterState.Idle] = new float?(1f);
			cde.c[CharacterState.Die] = new float?(1f);
			cde.c[CharacterState.Attack1] = new float?(1f);
			cde.c[CharacterState.Custom1] = new float?(1f);
			cde.c[CharacterState.Custom2] = new float?(1f);
			cde.c[CharacterState.Custom3] = new float?(1f);
			cde.b[CharacterState.Stunned] = CharacterState.Idle;
			bz9.b[text5] = cde;
		}
		cde = new cde();
		cde.d = "plt";
		cde.e = "PlasmaTurret";
		cde.k = 70;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 1;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Attack1.ToString()] = 4;
		cde.a[CharacterState.Attack2.ToString()] = 4;
		cde.a[CharacterState.Custom1.ToString()] = 1;
		cde.a[CharacterState.Custom2.ToString()] = 14;
		cde.a[CharacterState.Custom3.ToString()] = 14;
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.Attack2] = new float?(1f);
		cde.c[CharacterState.Custom1] = new float?(1f);
		cde.c[CharacterState.Custom2] = new float?(1f);
		cde.c[CharacterState.Custom3] = new float?(1f);
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		bz9.b[bln.e6] = cde;
		cde = new cde();
		cde.d = "elt";
		cde.e = "ElectroTurret";
		cde.k = 70;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 1;
		cde.a[CharacterState.Die.ToString()] = 6;
		cde.a[CharacterState.Attack1.ToString()] = 1;
		cde.a[CharacterState.Custom1.ToString()] = 1;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom3.ToString()] = 9;
		cde.a[CharacterState.Custom4.ToString()] = 5;
		cde.a[CharacterState.Custom5.ToString()] = 5;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.e7] = cde;
		cde = new cde();
		cde.d = "sht";
		cde.e = "SporeTurret";
		cde.k = 95;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 1;
		cde.a[CharacterState.Die.ToString()] = 12;
		cde.a[CharacterState.Attack1.ToString()] = 9;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		bz9.b[bln.e8] = cde;
		cde = new cde();
		cde.d = "wbot1";
		cde.e = "WheeledBot1";
		cde.k = 65;
		cde.j = new Point(0, 30);
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 1;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 3;
		cde.a[CharacterState.Attack2.ToString()] = 10;
		cde.a[CharacterState.OperateShort.ToString()] = 9;
		cde.a[CharacterState.Operating.ToString()] = 4;
		cde.c[CharacterState.Idle] = new float?(1.4f);
		cde.c[CharacterState.Die] = new float?(1.4f);
		cde.c[CharacterState.Move] = new float?(1.4f);
		cde.c[CharacterState.Attack1] = new float?(1.4f);
		cde.c[CharacterState.Attack2] = new float?(1.4f);
		cde.c[CharacterState.OperateShort] = new float?(1.4f);
		cde.c[CharacterState.Operating] = new float?(1.4f);
		cde.b[CharacterState.ChannelPsi] = CharacterState.Operating;
		cde.b[CharacterState.CastingPsi] = CharacterState.Operating;
		cde.b[CharacterState.Throw] = CharacterState.Attack2;
		cde.b[CharacterState.FinishPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		bz9.b[bln.e9] = cde;
		cde = new cde();
		cde.d = "mbot";
		cde.e = "MiniBot";
		cde.k = 50;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 1;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 3;
		cde.a[CharacterState.OperateShort.ToString()] = 9;
		cde.a[CharacterState.Operating.ToString()] = 4;
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Move] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.OperateShort] = new float?(1f);
		cde.c[CharacterState.Operating] = new float?(1f);
		cde.b[CharacterState.ChannelPsi] = CharacterState.Operating;
		cde.b[CharacterState.CastingPsi] = CharacterState.Operating;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		cde.b[CharacterState.FinishPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.fe] = cde;
		cde = new cde();
		cde.d = "tb";
		cde.e = "ThreadBot";
		cde.k = 85;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 9;
		cde.a[CharacterState.FinishPsi.ToString()] = 4;
		cde.a[CharacterState.ChannelPsi.ToString()] = 7;
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Move] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.FinishPsi] = new float?(1f);
		cde.c[CharacterState.ChannelPsi] = new float?(1f);
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		bz9.b[bln.fd] = cde;
		cde = new cde();
		cde.d = "sb";
		cde.e = "SuicideBot";
		cde.k = 40;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(0.6f);
		cde.c[CharacterState.Die] = new float?(0.6f);
		cde.c[CharacterState.Move] = new float?(0.6f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 6;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.b[CharacterState.Operating] = CharacterState.Idle;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Idle;
		cde.b[CharacterState.Attack1] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Idle;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		bz9.b[bln.fa] = cde;
		cde = new cde();
		cde.d = "plsen";
		cde.e = "PlasmaSentry";
		cde.k = 80;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.25f);
		cde.c[CharacterState.Attack2] = new float?(1.25f);
		cde.c[CharacterState.OperateShort] = new float?(1.25f);
		cde.c[CharacterState.Operating] = new float?(1.25f);
		cde.c[CharacterState.Custom1] = new float?(1.25f);
		cde.c[CharacterState.Custom2] = new float?(1.25f);
		cde.c[CharacterState.Custom3] = new float?(1.25f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.OperateShort.ToString()] = 9;
		cde.a[CharacterState.Operating.ToString()] = 4;
		cde.a[CharacterState.Attack1.ToString()] = 4;
		cde.a[CharacterState.Attack2.ToString()] = 4;
		cde.a[CharacterState.Custom1.ToString()] = 10;
		cde.a[CharacterState.Custom2.ToString()] = 10;
		cde.a[CharacterState.Custom3.ToString()] = 4;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		bz9.b[bln.fb] = cde;
		cde = new cde();
		cde.d = "cc";
		cde.e = "ChopChop";
		cde.k = 80;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.25f);
		cde.c[CharacterState.OperateShort] = new float?(1.25f);
		cde.c[CharacterState.Operating] = new float?(1.25f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.OperateShort.ToString()] = 9;
		cde.a[CharacterState.Operating.ToString()] = 4;
		cde.a[CharacterState.Attack1.ToString()] = 9;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.ff] = cde;
		cde = bz9.b(1f);
		cde.d = "pg";
		cde.e = "Pig";
		cde.k = 65;
		bz9.b[bln.ed] = cde;
		cde = bz9.b(1f);
		cde.d = "pgb";
		cde.e = "Pig";
		cde.k = 65;
		bz9.b[bln.ee] = cde;
		cde = bz9.b(1.2f);
		cde.d = "boar";
		cde.e = "Boar";
		cde.k = 70;
		cde.a[CharacterState.Custom3.ToString()] = 13;
		bz9.b[bln.ef] = cde;
		cde = new cde();
		cde.d = "flc";
		cde.e = "FacelessCentaur";
		cde.k = 82;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.25f);
		cde.c[CharacterState.CastingPsi] = new float?(1.25f);
		cde.c[CharacterState.ChannelPsi] = new float?(1.25f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.25f);
		cde.c[CharacterState.Attack2] = new float?(1.25f);
		cde.c[CharacterState.Stunned] = new float?(1.25f);
		cde.c[CharacterState.OperateShort] = new float?(1.25f);
		cde.c[CharacterState.Operating] = new float?(1.25f);
		cde.c[CharacterState.Throw] = new float?(1.25f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.OperateShort.ToString()] = 3;
		cde.a[CharacterState.Operating.ToString()] = 6;
		cde.a[CharacterState.Attack1.ToString()] = 3;
		cde.a[CharacterState.Attack2.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 7;
		cde.a[CharacterState.ChannelPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Throw.ToString()] = 7;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		bz9.b[bln.dg] = cde;
		cde = bz9.a(bln.df, Gender.Male, false, true, null, 0, null, false);
		cde.a[CharacterState.Custom1.ToString()] = 10;
		cde.a[CharacterState.Custom2.ToString()] = 5;
		cde.a[CharacterState.Custom3.ToString()] = 10;
		cde.a[CharacterState.Custom4.ToString()] = 5;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.df] = cde;
		cde = bz9.a(bln.dj, Gender.Male, false, true, "FacelessGeneral", 0, null, false);
		cde.a[CharacterState.Attack1.ToString()] = 4;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.dj] = cde;
		cde = bz9.a(bln.di, Gender.Male, false, false, "FacelessStalker", 0, null, false);
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 7;
		cde.a[CharacterState.Custom1.ToString()] = 7;
		cde.a[CharacterState.Custom2.ToString()] = 7;
		bz9.b[bln.di] = cde;
		cde = bz9.a(bln.dh, Gender.Male, false, true, null, 0, null, false);
		cde.a[CharacterState.Custom1.ToString()] = 5;
		cde.a[CharacterState.Custom2.ToString()] = 4;
		cde.a[CharacterState.Custom3.ToString()] = 5;
		bz9.b[bln.dh] = cde;
		cde = bz9.a(bln.dk, Gender.Male, false, true, null, 0, null, false);
		cde.e = "RathoundKing";
		bz9.b[bln.dk] = cde;
		bz9.b[bln.eg] = bz9.b("bld1");
		bz9.b[bln.eh] = bz9.b("bld2");
		bz9.b[bln.ei] = bz9.b("bld3");
		cde = new cde();
		cde.d = "brr";
		cde.e = "Borer";
		cde.k = 48;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(0.5f);
		cde.c[CharacterState.Die] = new float?(0.5f);
		cde.c[CharacterState.Move] = new float?(0.5f);
		cde.c[CharacterState.Attack1] = new float?(0.5f);
		cde.c[CharacterState.Stunned] = new float?(0.5f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 4;
		cde.a[CharacterState.Attack1.ToString()] = 9;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.b[CharacterState.Operating] = CharacterState.Attack1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.FinishPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.ej] = cde;
		cde = new cde();
		cde.d = "shl";
		cde.e = "Latcher";
		cde.k = 48;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(0.5f);
		cde.c[CharacterState.Die] = new float?(0.5f);
		cde.c[CharacterState.Move] = new float?(0.5f);
		cde.c[CharacterState.Attack1] = new float?(0.5f);
		cde.c[CharacterState.Stunned] = new float?(0.5f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 4;
		cde.a[CharacterState.Attack1.ToString()] = 9;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.b[CharacterState.Operating] = CharacterState.Attack1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.FinishPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.et] = cde;
		cde = new cde();
		cde.d = "blb";
		cde.e = "BladeBeast";
		cde.k = 90;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.5f);
		cde.c[CharacterState.Die] = new float?(1.5f);
		cde.c[CharacterState.Move] = new float?(1.5f);
		cde.c[CharacterState.FinishPsi] = new float?(1.5f);
		cde.c[CharacterState.Attack1] = new float?(1.5f);
		cde.c[CharacterState.Attack2] = new float?(1.5f);
		cde.c[CharacterState.Stunned] = new float?(1.5f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 2;
		cde.a[CharacterState.Custom2.ToString()] = 5;
		cde.a[CharacterState.Custom3.ToString()] = 5;
		cde.b[CharacterState.Operating] = CharacterState.Attack1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		bz9.b[bln.ek] = cde;
		cde = new cde();
		cde.d = "ps";
		cde.e = "PowerSuit";
		cde.k = 135;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.25f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.25f);
		cde.c[CharacterState.Attack2] = new float?(1.25f);
		cde.c[CharacterState.Stunned] = new float?(1.25f);
		cde.c[CharacterState.RaiseWeapon] = new float?(1.25f);
		cde.c[CharacterState.LowerWeapon] = new float?(1.25f);
		cde.c[CharacterState.Custom1] = new float?(1.25f);
		cde.c[CharacterState.Custom2] = new float?(1.25f);
		cde.c[CharacterState.Custom3] = new float?(1.25f);
		cde.c[CharacterState.Custom4] = new float?(1.25f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 12;
		cde.a[CharacterState.Attack1.ToString()] = 3;
		cde.a[CharacterState.Attack2.ToString()] = 12;
		cde.a[CharacterState.FinishPsi.ToString()] = 7;
		cde.a[CharacterState.RaiseWeapon.ToString()] = 6;
		cde.a[CharacterState.LowerWeapon.ToString()] = 6;
		cde.a[CharacterState.Custom1.ToString()] = 1;
		cde.a[CharacterState.Custom2.ToString()] = 1;
		cde.a[CharacterState.Custom3.ToString()] = 12;
		cde.a[CharacterState.Custom4.ToString()] = 12;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		cde.b[CharacterState.Operating] = CharacterState.Idle;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Idle;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		cde.b[CharacterState.Throw] = CharacterState.FinishPsi;
		cde.b[CharacterState.OperateShort] = CharacterState.RaiseWeapon;
		bz9.b[bln.fc] = cde;
		cde = new cde();
		cde.d = "tc1";
		cde.e = "Tentacle1";
		cde.k = 190;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 10;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Die.ToString()] = 4;
		cde.a[CharacterState.Custom1.ToString()] = 6;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.Move] = CharacterState.Idle;
		cde.b[CharacterState.OperateShort] = CharacterState.Custom1;
		cde.b[CharacterState.Throw] = CharacterState.Custom2;
		cde.b[CharacterState.FinishPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		bz9.b[bln.fj] = cde;
		cde = new cde();
		cde.d = "tc2";
		cde.e = "Tentacle1";
		cde.k = 190;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 10;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Die.ToString()] = 4;
		cde.a[CharacterState.Custom1.ToString()] = 6;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.Move] = CharacterState.Idle;
		bz9.b[bln.fk] = cde;
		cde = new cde();
		cde.d = "tc3";
		cde.e = "Tentacle1";
		cde.k = 190;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 10;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Die.ToString()] = 4;
		cde.a[CharacterState.Custom1.ToString()] = 6;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.Move] = CharacterState.Idle;
		bz9.b[bln.fl] = cde;
		cde = new cde();
		cde.d = "tc4";
		cde.e = "Tentacle1";
		cde.k = 190;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 10;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 4;
		cde.a[CharacterState.Die.ToString()] = 4;
		cde.a[CharacterState.Custom1.ToString()] = 6;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.Move] = CharacterState.Idle;
		bz9.b[bln.fm] = cde;
		cde = new cde();
		cde.d = "tc5";
		cde.e = "Tentacle1";
		cde.k = 190;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 10;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 7;
		cde.a[CharacterState.Die.ToString()] = 4;
		cde.a[CharacterState.Custom1.ToString()] = 6;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.b[CharacterState.Move] = CharacterState.Idle;
		bz9.b[bln.fn] = cde;
		cde = new cde();
		cde.d = "tc6";
		cde.e = "Tentacle1";
		cde.k = 190;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 10;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 7;
		cde.a[CharacterState.Die.ToString()] = 4;
		cde.a[CharacterState.Custom1.ToString()] = 6;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.b[CharacterState.Move] = CharacterState.Idle;
		bz9.b[bln.fo] = cde;
		cde = new cde();
		cde.d = "tc7";
		cde.e = "Tentacle1";
		cde.k = 190;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 10;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 4;
		cde.a[CharacterState.FinishPsi.ToString()] = 7;
		cde.a[CharacterState.Die.ToString()] = 4;
		cde.a[CharacterState.Custom1.ToString()] = 6;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.b[CharacterState.Move] = CharacterState.Idle;
		bz9.b[bln.fp] = cde;
		cde = new cde();
		cde.d = bln.f2;
		cde.e = "Jetski";
		cde.k = 70;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 13;
		cde.a[CharacterState.Move.ToString()] = 10;
		cde.b[CharacterState.Attack1] = CharacterState.Idle;
		cde.b[CharacterState.Attack2] = CharacterState.Idle;
		cde.b[CharacterState.FinishPsi] = CharacterState.Idle;
		cde.b[CharacterState.OperateShort] = CharacterState.Idle;
		cde.b[CharacterState.Operating] = CharacterState.Idle;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Idle;
		cde.b[CharacterState.Die] = CharacterState.Idle;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		cde.b[CharacterState.Throw] = CharacterState.Idle;
		bz9.b[bln.f2] = cde;
		cde = new cde();
		cde.d = "xpbl_crabn";
		cde.e = "xpbl_Crab";
		cde.k = 50;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.05f);
		cde.c[CharacterState.CastingPsi] = new float?(1.05f);
		cde.c[CharacterState.Die] = new float?(1.05f);
		cde.c[CharacterState.Move] = new float?(1.1f);
		cde.c[CharacterState.FinishPsi] = new float?(1.15f);
		cde.c[CharacterState.Attack1] = new float?(1.15f);
		cde.c[CharacterState.Attack2] = new float?(1.15f);
		cde.c[CharacterState.Stunned] = new float?(1.05f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Attack2.ToString()] = 8;
		bz9.b[bln.f6] = cde;
		cde = new cde();
		cde.d = "xpbl_crabb";
		cde.e = "xpbl_Crab_Big";
		cde.k = 55;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.05f);
		cde.c[CharacterState.CastingPsi] = new float?(1.05f);
		cde.c[CharacterState.Die] = new float?(1.05f);
		cde.c[CharacterState.Move] = new float?(1.1f);
		cde.c[CharacterState.FinishPsi] = new float?(1.15f);
		cde.c[CharacterState.Attack1] = new float?(1.15f);
		cde.c[CharacterState.Attack2] = new float?(1.15f);
		cde.c[CharacterState.Stunned] = new float?(1.05f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Attack2.ToString()] = 8;
		bz9.b[bln.f8] = cde;
		cde = new cde();
		cde.d = "xpbl_crabp";
		cde.e = "xpbl_Crab_Psi";
		cde.k = 60;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.05f);
		cde.c[CharacterState.CastingPsi] = new float?(1.05f);
		cde.c[CharacterState.Die] = new float?(1.05f);
		cde.c[CharacterState.Move] = new float?(1.1f);
		cde.c[CharacterState.FinishPsi] = new float?(1.15f);
		cde.c[CharacterState.Attack1] = new float?(1.15f);
		cde.c[CharacterState.Attack2] = new float?(1.15f);
		cde.c[CharacterState.Stunned] = new float?(1.05f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Attack2.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 5;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		bz9.b[bln.f7] = cde;
		for (int k = 1; k <= 9; k++)
		{
			cde = new cde();
			cde.d = "xpbl_hrm" + k.ToString();
			cde.e = "Xpbl_Hermit";
			cde.k = 50;
			cde.f = false;
			cde.g = false;
			cde.c[CharacterState.Idle] = new float?(1f);
			cde.c[CharacterState.Die] = new float?(1f);
			cde.c[CharacterState.Move] = new float?(1f);
			cde.c[CharacterState.FinishPsi] = new float?(1f);
			cde.c[CharacterState.Attack1] = new float?(1f);
			cde.c[CharacterState.Stunned] = new float?(1f);
			cde.a[CharacterState.Idle.ToString()] = 8;
			cde.a[CharacterState.Move.ToString()] = 8;
			cde.a[CharacterState.Stunned.ToString()] = 8;
			cde.a[CharacterState.Die.ToString()] = 5;
			cde.a[CharacterState.Custom1.ToString()] = 1;
			cde.a[CharacterState.Custom2.ToString()] = 9;
			cde.a[CharacterState.Attack1.ToString()] = 5;
			cde.b[CharacterState.Attack2] = CharacterState.Attack1;
			bz9.b["xpbl_hermitcrab" + k.ToString()] = cde;
		}
		cde = new cde();
		cde.f = false;
		cde.g = false;
		cde.d = "Xpbl_dg_dbm";
		cde.e = "xpbl_Dog_Doberman";
		cde.k = 70;
		cde.c[CharacterState.Idle] = new float?(0.8f);
		cde.c[CharacterState.Die] = new float?(0.8f);
		cde.c[CharacterState.Move] = new float?(0.8f);
		cde.c[CharacterState.Custom1] = new float?(0.8f);
		cde.c[CharacterState.Custom2] = new float?(0.8f);
		cde.c[CharacterState.Custom3] = new float?(0.8f);
		cde.c[CharacterState.Custom4] = new float?(0.8f);
		cde.c[CharacterState.Attack1] = new float?(0.8f);
		cde.c[CharacterState.Stunned] = new float?(0.8f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 7;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom3.ToString()] = 6;
		cde.a[CharacterState.Custom4.ToString()] = 6;
		cde.b[CharacterState.Operating] = CharacterState.Custom2;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Custom4;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Custom3;
		bz9.b[bln.gi] = cde;
		cde = new cde();
		cde.f = false;
		cde.g = false;
		cde.d = "Xpbl_dg_pbb";
		cde.e = "xpbl_Dog_Pitbull";
		cde.k = 55;
		cde.c[CharacterState.Idle] = new float?(0.8f);
		cde.c[CharacterState.Die] = new float?(0.8f);
		cde.c[CharacterState.Move] = new float?(0.8f);
		cde.c[CharacterState.Custom1] = new float?(0.8f);
		cde.c[CharacterState.Custom2] = new float?(0.8f);
		cde.c[CharacterState.Custom3] = new float?(0.8f);
		cde.c[CharacterState.Custom4] = new float?(0.8f);
		cde.c[CharacterState.Attack1] = new float?(0.8f);
		cde.c[CharacterState.Stunned] = new float?(0.8f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 7;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom3.ToString()] = 6;
		cde.a[CharacterState.Custom4.ToString()] = 6;
		cde.b[CharacterState.Operating] = CharacterState.Custom2;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Custom4;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Custom3;
		bz9.b[bln.gj] = cde;
		cde = new cde();
		cde.f = false;
		cde.g = false;
		cde.d = "Xpbl_dg_pbw";
		cde.e = "xpbl_Dog_Pitbull";
		cde.k = 55;
		cde.c[CharacterState.Idle] = new float?(0.8f);
		cde.c[CharacterState.Die] = new float?(0.8f);
		cde.c[CharacterState.Move] = new float?(0.8f);
		cde.c[CharacterState.Custom1] = new float?(0.8f);
		cde.c[CharacterState.Custom2] = new float?(0.8f);
		cde.c[CharacterState.Custom3] = new float?(0.8f);
		cde.c[CharacterState.Custom4] = new float?(0.8f);
		cde.c[CharacterState.Attack1] = new float?(0.8f);
		cde.c[CharacterState.Stunned] = new float?(0.8f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 7;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom3.ToString()] = 6;
		cde.a[CharacterState.Custom4.ToString()] = 6;
		cde.b[CharacterState.Operating] = CharacterState.Custom2;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Custom4;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Custom3;
		bz9.b[bln.gk] = cde;
		foreach (string text6 in new string[]
		{
			bln.gl,
			bln.gm
		})
		{
			cde = new cde();
			cde.f = false;
			cde.g = false;
			cde.d = text6.ToLowerInvariant();
			cde.e = "SmallCrab";
			cde.k = 40;
			cde.a[CharacterState.Idle.ToString()] = 8;
			cde.a[CharacterState.Die.ToString()] = 8;
			cde.a[CharacterState.Move.ToString()] = 8;
			cde.a[CharacterState.Attack1.ToString()] = 8;
			cde.a[CharacterState.Stunned.ToString()] = 8;
			cde.a[CharacterState.Custom1.ToString()] = 8;
			cde.a[CharacterState.Custom2.ToString()] = 8;
			cde.a[CharacterState.Custom3.ToString()] = 8;
			cde.b[CharacterState.Operating] = CharacterState.Attack1;
			cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
			cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
			cde.b[CharacterState.Throw] = CharacterState.Attack1;
			cde.b[CharacterState.Attack2] = CharacterState.Attack1;
			cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
			bz9.b[text6] = cde;
		}
		cde = new cde();
		cde.d = "xpbl_sph2";
		cde.e = "xpbl_GreaterSiphoner";
		cde.k = 85;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.25f);
		cde.c[CharacterState.Die] = new float?(1.25f);
		cde.c[CharacterState.Move] = new float?(1.25f);
		cde.c[CharacterState.Stunned] = new float?(1.25f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.Attack1] = new float?(1.25f);
		cde.c[CharacterState.FinishPsi] = new float?(1.25f);
		cde.c[CharacterState.ChannelPsi] = new float?(1.25f);
		cde.c[CharacterState.Custom1] = new float?(1.25f);
		cde.c[CharacterState.Custom2] = new float?(1.25f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 7;
		cde.a[CharacterState.ChannelPsi.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 4;
		cde.a[CharacterState.Custom2.ToString()] = 6;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.gz] = cde;
		foreach (string text7 in new string[]
		{
			bln.g0,
			bln.g1,
			bln.g2
		})
		{
			cde = new cde();
			cde.d = text7;
			cde.e = "xpbl_Tarantula";
			cde.k = 60;
			cde.f = false;
			cde.g = false;
			cde.c[CharacterState.Idle] = new float?(1f);
			cde.c[CharacterState.Die] = new float?(1f);
			cde.c[CharacterState.Move] = new float?(1f);
			cde.c[CharacterState.Stunned] = new float?(1f);
			cde.c[CharacterState.Attack1] = new float?(1f);
			cde.c[CharacterState.Attack2] = new float?(1f);
			cde.a[CharacterState.Idle.ToString()] = 8;
			cde.a[CharacterState.Die.ToString()] = 9;
			cde.a[CharacterState.Attack1.ToString()] = 7;
			cde.a[CharacterState.Attack2.ToString()] = 13;
			cde.a[CharacterState.Move.ToString()] = 8;
			cde.a[CharacterState.Stunned.ToString()] = 8;
			bz9.b[text7] = cde;
		}
		foreach (string text8 in new string[]
		{
			bln.g3,
			bln.g4,
			bln.g5
		})
		{
			cde = new cde();
			cde.d = text8;
			cde.e = "xpbl_GiantWeaver";
			cde.k = 85;
			cde.f = false;
			cde.g = false;
			cde.c[CharacterState.Idle] = new float?(1f);
			cde.c[CharacterState.Die] = new float?(1f);
			cde.c[CharacterState.Move] = new float?(1f);
			cde.c[CharacterState.Stunned] = new float?(1f);
			cde.c[CharacterState.Attack1] = new float?(1f);
			cde.c[CharacterState.Attack2] = new float?(1f);
			cde.c[CharacterState.LowerWeapon] = new float?(1f);
			cde.c[CharacterState.RaiseWeapon] = new float?(1f);
			cde.c[CharacterState.Custom1] = new float?(1f);
			cde.c[CharacterState.Custom2] = new float?(1f);
			cde.c[CharacterState.Custom3] = new float?(1f);
			cde.c[CharacterState.Custom4] = new float?(1f);
			cde.a[CharacterState.Idle.ToString()] = 8;
			cde.a[CharacterState.Die.ToString()] = 9;
			cde.a[CharacterState.Attack1.ToString()] = 7;
			cde.a[CharacterState.Attack2.ToString()] = 5;
			cde.a[CharacterState.Move.ToString()] = 8;
			cde.a[CharacterState.Stunned.ToString()] = 8;
			cde.a[CharacterState.LowerWeapon.ToString()] = 5;
			cde.a[CharacterState.RaiseWeapon.ToString()] = 5;
			cde.a[CharacterState.Custom1.ToString()] = 11;
			cde.a[CharacterState.Custom2.ToString()] = 5;
			cde.a[CharacterState.Custom3.ToString()] = 5;
			cde.a[CharacterState.Custom4.ToString()] = 5;
			bz9.b[text8] = cde;
		}
		foreach (string text9 in new string[]
		{
			bln.ij,
			bln.ik
		})
		{
			cde = new cde();
			cde.d = text9;
			cde.e = "Xpbl_StoneRobot";
			cde.k = 110;
			cde.f = false;
			cde.g = true;
			cde.c[CharacterState.Idle] = new float?(1f);
			cde.c[CharacterState.Die] = new float?(1f);
			cde.c[CharacterState.Move] = new float?(1f);
			cde.c[CharacterState.Attack1] = new float?(1f);
			cde.c[CharacterState.Attack2] = new float?(1f);
			cde.c[CharacterState.OperateShort] = new float?(1f);
			cde.c[CharacterState.Operating] = new float?(1f);
			cde.c[CharacterState.Custom1] = new float?(1f);
			cde.c[CharacterState.Custom2] = new float?(1f);
			cde.c[CharacterState.Custom3] = new float?(1f);
			cde.c[CharacterState.Custom4] = new float?(1f);
			cde.a[CharacterState.Idle.ToString()] = 8;
			cde.a[CharacterState.Die.ToString()] = 9;
			cde.a[CharacterState.Attack1.ToString()] = 9;
			cde.a[CharacterState.Attack2.ToString()] = 9;
			cde.a[CharacterState.Attack1.ToString() + an3.a] = 9;
			cde.a[CharacterState.Attack2.ToString() + an3.a] = 9;
			cde.a[CharacterState.Move.ToString()] = 8;
			cde.a[CharacterState.Stunned.ToString()] = 8;
			cde.a[CharacterState.Operating.ToString()] = 8;
			cde.a[CharacterState.OperateShort.ToString()] = 5;
			cde.a[CharacterState.Custom1.ToString()] = 1;
			cde.a[CharacterState.Custom2.ToString()] = 16;
			cde.a[CharacterState.Custom3.ToString()] = 9;
			cde.a[CharacterState.Custom4.ToString()] = 9;
			cde.b[CharacterState.Stunned] = CharacterState.Idle;
			cde.b[CharacterState.FinishPsi] = CharacterState.OperateShort;
			cde.b[CharacterState.Throw] = CharacterState.OperateShort;
			cde.b[CharacterState.CastingPsi] = CharacterState.Operating;
			cde.b[CharacterState.ChannelPsi] = CharacterState.Operating;
			bz9.b[text9] = cde;
		}
		foreach (string text10 in new string[]
		{
			bln.il,
			bln.im
		})
		{
			foreach (string text11 in new string[]
			{
				"",
				"ac",
				"acl",
				"bob",
				"bobl",
				"eb",
				"rc",
				"pb",
				"pbl",
				"nb"
			})
			{
				string text12 = text10;
				if (!string.IsNullOrEmpty(text11))
				{
					text12 = text10 + "_" + text11;
				}
				cde = new cde();
				cde.d = text12;
				cde.e = "Xpbl_StoneRobot";
				cde.k = 118;
				cde.f = false;
				cde.g = false;
				cde.c[CharacterState.Idle] = new float?(1f);
				cde.c[CharacterState.Die] = new float?(1f);
				cde.c[CharacterState.Move] = new float?(1f);
				cde.c[CharacterState.Attack1] = new float?(1f);
				cde.c[CharacterState.Attack2] = new float?(1f);
				cde.c[CharacterState.OperateShort] = new float?(1f);
				cde.c[CharacterState.Operating] = new float?(1f);
				cde.c[CharacterState.Throw] = new float?(1f);
				cde.c[CharacterState.Custom1] = new float?(1f);
				cde.c[CharacterState.Custom2] = new float?(1f);
				cde.c[CharacterState.Custom3] = new float?(1f);
				cde.a[CharacterState.Idle.ToString()] = 8;
				cde.a[CharacterState.Die.ToString()] = 9;
				cde.a[CharacterState.Attack1.ToString()] = 9;
				cde.a[CharacterState.Attack2.ToString()] = 9;
				cde.a[CharacterState.Move.ToString()] = 8;
				cde.a[CharacterState.Stunned.ToString()] = 8;
				cde.a[CharacterState.Operating.ToString()] = 8;
				cde.a[CharacterState.OperateShort.ToString()] = 4;
				cde.a[CharacterState.Throw.ToString()] = 7;
				cde.a[CharacterState.Custom1.ToString()] = 1;
				cde.a[CharacterState.Custom2.ToString()] = 8;
				cde.a[CharacterState.Custom3.ToString()] = 9;
				cde.b[CharacterState.Stunned] = CharacterState.Idle;
				cde.b[CharacterState.FinishPsi] = CharacterState.OperateShort;
				cde.b[CharacterState.CastingPsi] = CharacterState.Operating;
				cde.b[CharacterState.ChannelPsi] = CharacterState.Operating;
				if (!string.IsNullOrEmpty(text11))
				{
					cde.b[CharacterState.Attack2] = CharacterState.Attack1;
				}
				bz9.b[text12] = cde;
			}
		}
		foreach (string text13 in new string[]
		{
			bln.@in,
			bln.io
		})
		{
			cde = new cde();
			cde.d = text13;
			cde.e = "Xpbl_LemurianNagaProtector";
			cde.k = 165;
			cde.f = false;
			cde.g = false;
			float value = 1.4f;
			cde.c[CharacterState.Idle] = new float?(value);
			cde.c[CharacterState.Die] = new float?(value);
			cde.c[CharacterState.Move] = new float?(value);
			cde.c[CharacterState.Attack1] = new float?(value);
			cde.c[CharacterState.Attack2] = new float?(value);
			cde.c[CharacterState.RaiseWeapon] = new float?(value);
			cde.c[CharacterState.LowerWeapon] = new float?(value);
			cde.c[CharacterState.Stunned] = new float?(value);
			cde.c[CharacterState.Custom1] = new float?(value);
			cde.c[CharacterState.Custom2] = new float?(value);
			cde.a[CharacterState.Idle.ToString()] = 8;
			cde.a[CharacterState.Die.ToString()] = 9;
			cde.a[CharacterState.Move.ToString()] = 8;
			cde.a[CharacterState.Attack1.ToString()] = 8;
			cde.a[CharacterState.Attack2.ToString()] = 8;
			cde.a[CharacterState.RaiseWeapon.ToString()] = 6;
			cde.a[CharacterState.LowerWeapon.ToString()] = 6;
			cde.a[CharacterState.Stunned.ToString()] = 1;
			cde.a[CharacterState.Custom1.ToString()] = 1;
			cde.a[CharacterState.Custom2.ToString()] = 9;
			cde.b[CharacterState.Operating] = CharacterState.Idle;
			cde.b[CharacterState.ChannelPsi] = CharacterState.Idle;
			cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
			cde.b[CharacterState.Throw] = CharacterState.Attack2;
			cde.b[CharacterState.OperateShort] = CharacterState.Attack2;
			bz9.b[text13] = cde;
		}
		cde = new cde();
		cde.d = bln.gn;
		cde.e = "Xpbl_SeaSerpent";
		cde.k = 100;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom3.ToString()] = 10;
		cde.a[CharacterState.Custom4.ToString()] = 13;
		cde.a[CharacterState.Custom5.ToString()] = 9;
		cde.a[CharacterState.Custom6.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.gn] = cde;
		cde = new cde();
		cde.d = bln.go;
		cde.e = "Xpbl_SeaSerpent";
		cde.k = 100;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom3.ToString()] = 10;
		cde.a[CharacterState.Custom4.ToString()] = 13;
		cde.a[CharacterState.Custom5.ToString()] = 9;
		cde.a[CharacterState.Custom6.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.go] = cde;
		cde = new cde();
		cde.d = bln.gp;
		cde.e = "Xpbl_SeaSerpent";
		cde.k = 120;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Attack2.ToString()] = 7;
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom3.ToString()] = 10;
		cde.a[CharacterState.Custom4.ToString()] = 12;
		cde.a[CharacterState.Custom5.ToString()] = 9;
		cde.a[CharacterState.Custom6.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		bz9.b[bln.gp] = cde;
		cde = bz9.a(1.2f);
		cde.d = "xpbl_buffb1";
		cde.k = 80;
		bz9.b[bln.gu] = cde;
		cde = bz9.a(1.2f);
		cde.d = "xpbl_buffb2";
		cde.k = 80;
		bz9.b[bln.gv] = cde;
		cde = bz9.a(1f);
		cde.d = "xpbl_buff1";
		cde.k = 65;
		bz9.b[bln.gq] = cde;
		cde = bz9.a(1f);
		cde.d = "xpbl_buff2";
		cde.k = 65;
		bz9.b[bln.gr] = cde;
		cde = bz9.a(1f);
		cde.d = "xpbl_buff3";
		cde.k = 65;
		bz9.b[bln.gs] = cde;
		cde = bz9.a(1f);
		cde.d = "xpbl_buff4";
		cde.k = 65;
		bz9.b[bln.gt] = cde;
		cde = bz9.a(0.8f);
		cde.d = "xpbl_buffc1";
		cde.k = 45;
		bz9.b[bln.gw] = cde;
		cde = bz9.a(0.8f);
		cde.d = "xpbl_buffc2";
		cde.k = 45;
		bz9.b[bln.gx] = cde;
		cde = bz9.a(0.8f);
		cde.d = "xpbl_buffc3";
		cde.k = 45;
		bz9.b[bln.gy] = cde;
		cde = bz9.a(1f, false);
		cde.d = "xpbl_str";
		cde.k = 55;
		bz9.b[bln.jn] = cde;
		cde = bz9.a(1f, true);
		cde.d = "xpbl_wstr";
		cde.k = 55;
		bz9.b[bln.jp] = cde;
		cde = bz9.a(0.6f, false);
		cde.d = "xpbl_strs";
		cde.k = 35;
		bz9.b[bln.jo] = cde;
		cde = bz9.a(0.6f, true);
		cde.d = "xpbl_wstrs";
		cde.k = 35;
		bz9.b[bln.jq] = cde;
		foreach (string text14 in new string[]
		{
			bln.jr,
			bln.js,
			bln.jt,
			bln.ju,
			bln.jv
		})
		{
			cde = bz9.a(text14);
			cde.d = text14;
			bz9.b[text14] = cde;
		}
		foreach (string text15 in new string[]
		{
			bln.jw,
			bln.jx,
			bln.jy,
			bln.jz
		})
		{
			cde = new cde();
			cde.d = text15;
			cde.e = "Xpbl_SeaHorseTurret";
			cde.k = 120;
			cde.f = false;
			cde.g = false;
			cde.a[CharacterState.Idle.ToString()] = 1;
			cde.a[CharacterState.Die.ToString()] = 8;
			cde.a[CharacterState.Attack1.ToString()] = 4;
			cde.a[CharacterState.Custom1.ToString()] = 1;
			cde.a[CharacterState.Custom2.ToString()] = 12;
			cde.a[CharacterState.Custom3.ToString()] = 12;
			cde.c[CharacterState.Idle] = new float?(1f);
			cde.c[CharacterState.Die] = new float?(1f);
			cde.c[CharacterState.Attack1] = new float?(1f);
			cde.c[CharacterState.Custom1] = new float?(1f);
			cde.c[CharacterState.Custom2] = new float?(1f);
			cde.c[CharacterState.Custom3] = new float?(1f);
			cde.b[CharacterState.Stunned] = CharacterState.Idle;
			bz9.b[text15] = cde;
		}
		bz9.b[bln.i6] = bz9.a(bln.i6, Gender.Male, false, true, "Xpbl_SavageHighShaman", 0, null, false);
		bz9.b[bln.i6].b[CharacterState.Attack2] = CharacterState.Attack1;
		bz9.b[bln.i6].c[CharacterState.Custom1] = bz9.b[bln.i6].c[CharacterState.Idle];
		bz9.b[bln.i6].a[CharacterState.Custom1.ToString()] = 8;
		cde = bz9.a(bln.i7, Gender.Male, false, true, "Xpbl_SavageKing", 0, null, false);
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 8;
		cde.a[CharacterState.Custom3.ToString()] = 6;
		cde.a[CharacterState.Custom4.ToString()] = 7;
		cde.a[CharacterState.Custom5.ToString()] = 5;
		cde.a[CharacterState.Custom6.ToString()] = 8;
		cde.c[CharacterState.Custom1] = new float?(1f);
		cde.c[CharacterState.Custom2] = new float?(1f);
		cde.c[CharacterState.Custom3] = new float?(1f);
		cde.c[CharacterState.Custom4] = new float?(1f);
		cde.c[CharacterState.Custom5] = new float?(1f);
		cde.c[CharacterState.Custom6] = new float?(1f);
		cde.b[CharacterState.FinishPsi] = CharacterState.Custom2;
		bz9.b[bln.i7] = cde;
		cde = bz9.a(bln.i8, Gender.Male, false, true, "Xpbl_SavageKingOnThrone", 0, null, false);
		cde.a[CharacterState.Custom1.ToString()] = 10;
		cde.a[CharacterState.Custom2.ToString()] = 9;
		cde.a[CharacterState.Custom4.ToString()] = 7;
		cde.a[CharacterState.Custom5.ToString()] = 5;
		cde.a[CharacterState.Custom6.ToString()] = 8;
		cde.c[CharacterState.Custom1] = new float?(1f);
		cde.c[CharacterState.Custom4] = new float?(1f);
		cde.c[CharacterState.Custom5] = new float?(1f);
		cde.c[CharacterState.Custom6] = new float?(1f);
		bz9.b[bln.i8] = cde;
		foreach (string text16 in new string[]
		{
			bln.jj,
			bln.jk,
			bln.jl
		})
		{
			cde = new cde();
			cde.d = text16;
			cde.e = "Xpbl_SavageBallista";
			cde.k = 95;
			cde.f = false;
			cde.g = false;
			cde.a[CharacterState.Idle.ToString()] = 8;
			cde.a[CharacterState.Die.ToString()] = 8;
			cde.a[CharacterState.Attack1.ToString()] = 6;
			cde.a[CharacterState.Stunned.ToString()] = 8;
			cde.a[CharacterState.LowerWeapon.ToString()] = 8;
			cde.c[CharacterState.Idle] = new float?(1f);
			cde.c[CharacterState.Die] = new float?(1f);
			cde.c[CharacterState.Attack1] = new float?(1f);
			cde.c[CharacterState.Stunned] = new float?(1f);
			cde.c[CharacterState.LowerWeapon] = new float?(1f);
			cde.b[CharacterState.Operating] = CharacterState.Idle;
			cde.b[CharacterState.OperateShort] = CharacterState.Idle;
			bz9.b[text16] = cde;
		}
		foreach (string text17 in new string[]
		{
			bln.g6,
			bln.g7,
			bln.g8
		})
		{
			cde = new cde();
			cde.d = text17;
			cde.e = "xpbl_SpaceSnake";
			cde.k = 100;
			cde.f = false;
			cde.g = false;
			cde.a[CharacterState.Idle.ToString()] = 8;
			cde.a[CharacterState.Die.ToString()] = 8;
			cde.a[CharacterState.Attack1.ToString()] = 6;
			cde.a[CharacterState.Move.ToString()] = 8;
			cde.b[CharacterState.Stunned] = CharacterState.Idle;
			bz9.b[text17] = cde;
		}
		cde = new cde();
		cde.d = "xpbl_sdk";
		cde.e = "xpbl_SpaceDustKing";
		cde.k = 130;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 13;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Attack2.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 9;
		cde.b[CharacterState.Stunned] = CharacterState.Idle;
		bz9.b[bln.g9] = cde;
		foreach (string text18 in new string[]
		{
			bln.l2,
			bln.l3,
			bln.l4,
			bln.l5
		})
		{
			cde = new cde();
			cde.d = text18;
			cde.e = "Xphw_BostonBot";
			cde.k = 95;
			cde.f = false;
			cde.g = false;
			cde.c[CharacterState.Idle] = new float?(1.25f);
			cde.c[CharacterState.Die] = new float?(1.25f);
			cde.c[CharacterState.Move] = new float?(1.25f);
			cde.c[CharacterState.Attack1] = new float?(1.25f);
			cde.c[CharacterState.RaiseWeapon] = new float?(1.25f);
			cde.c[CharacterState.LowerWeapon] = new float?(1.25f);
			cde.a[CharacterState.Idle.ToString()] = 8;
			cde.a[CharacterState.Die.ToString()] = 10;
			cde.a[CharacterState.Move.ToString()] = 8;
			cde.a[CharacterState.Attack1.ToString()] = 6;
			cde.a[CharacterState.RaiseWeapon.ToString()] = 6;
			cde.a[CharacterState.LowerWeapon.ToString()] = 6;
			cde.b[CharacterState.Stunned] = CharacterState.Idle;
			cde.b[CharacterState.Attack2] = CharacterState.Attack1;
			bz9.b[text18] = cde;
		}
	}

	// Token: 0x06005F6A RID: 24426 RVA: 0x002940BC File Offset: 0x002922BC
	private static cde c(string A_0)
	{
		cde cde = new cde();
		cde.d = A_0;
		cde.e = "Cat";
		cde.k = 45;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(0.35f);
		cde.c[CharacterState.Die] = new float?(0.35f);
		cde.c[CharacterState.Move] = new float?(0.35f);
		cde.c[CharacterState.Custom1] = new float?(0.35f);
		cde.c[CharacterState.Custom2] = new float?(0.35f);
		cde.c[CharacterState.Custom3] = new float?(0.35f);
		cde.c[CharacterState.Custom4] = new float?(0.35f);
		cde.c[CharacterState.Attack1] = new float?(0.35f);
		cde.c[CharacterState.Stunned] = new float?(0.35f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 12;
		cde.a[CharacterState.Custom2.ToString()] = 12;
		cde.a[CharacterState.Custom3.ToString()] = 6;
		cde.a[CharacterState.Custom4.ToString()] = 6;
		cde.b[CharacterState.Operating] = CharacterState.Custom2;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Custom4;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Custom3;
		return cde;
	}

	// Token: 0x06005F6B RID: 24427 RVA: 0x00294310 File Offset: 0x00292510
	private static cde b(string A_0)
	{
		cde cde = new cde();
		cde.d = A_0;
		cde.e = "Меченосец";
		cde.k = 70;
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.05f);
		cde.c[CharacterState.Die] = new float?(1.05f);
		cde.c[CharacterState.Move] = new float?(1.1f);
		cde.c[CharacterState.FinishPsi] = new float?(1.15f);
		cde.c[CharacterState.Attack1] = new float?(1.15f);
		cde.c[CharacterState.Attack2] = new float?(1.15f);
		cde.c[CharacterState.Stunned] = new float?(1.05f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 2;
		cde.a[CharacterState.Custom2.ToString()] = 5;
		cde.a[CharacterState.Custom3.ToString()] = 5;
		cde.b[CharacterState.Operating] = CharacterState.Attack1;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		return cde;
	}

	// Token: 0x06005F6C RID: 24428 RVA: 0x0029453C File Offset: 0x0029273C
	private static cde b(string A_0, string A_1)
	{
		cde cde = new cde();
		cde.d = A_0;
		cde.e = A_1;
		cde.k = 120;
		cde.c[CharacterState.Idle] = new float?(1.05f);
		cde.c[CharacterState.Stunned] = new float?(1.05f);
		cde.c[CharacterState.Operating] = new float?(1.05f);
		cde.c[CharacterState.Die] = new float?(1.05f);
		cde.c[CharacterState.Move] = new float?(1.1f);
		cde.c[CharacterState.ChannelPsi] = new float?(1.15f);
		cde.c[CharacterState.CastingPsi] = new float?(1.15f);
		cde.c[CharacterState.Throw] = new float?(1.15f);
		cde.c[CharacterState.OperateShort] = new float?(1.05f);
		cde.c[CharacterState.FinishPsi] = new float?(1.15f);
		cde.c[CharacterState.Attack1] = new float?(1.15f);
		cde.c[CharacterState.Attack2] = new float?(1.15f);
		cde.c[CharacterState.RaiseWeapon] = new float?(1.15f);
		cde.c[CharacterState.LowerWeapon] = new float?(1.15f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 7;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 12;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack1;
		cde.b[CharacterState.Operating] = CharacterState.Idle;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Idle;
		return cde;
	}

	// Token: 0x06005F6D RID: 24429 RVA: 0x00294794 File Offset: 0x00292994
	private static cde a(string A_0, string A_1)
	{
		cde cde = new cde();
		cde.d = A_0;
		cde.e = A_1;
		cde.k = 120;
		float a_ = 1.05f;
		bz9.a(cde, CharacterState.Attack1, 6, a_);
		bz9.a(cde, CharacterState.Attack2, 7, a_);
		bz9.a(cde, CharacterState.Custom1, 8, a_);
		bz9.a(cde, CharacterState.Custom2, 10, a_);
		bz9.a(cde, CharacterState.Custom3, 13, a_);
		bz9.a(cde, CharacterState.Custom4, 13, a_);
		bz9.a(cde, CharacterState.Custom5, 17, a_);
		bz9.a(cde, CharacterState.Die, 10, a_);
		bz9.a(cde, CharacterState.FinishPsi, 12, a_);
		bz9.a(cde, CharacterState.Idle, 8, a_);
		bz9.a(cde, CharacterState.Move, 8, a_);
		bz9.a(cde, CharacterState.Operating, 6, a_);
		bz9.a(cde, CharacterState.OperateShort, 5, a_);
		bz9.a(cde, CharacterState.Stunned, 8, a_);
		bz9.a(cde, CharacterState.Throw, 7, a_);
		bz9.a(cde, CharacterState.Idle);
		return cde;
	}

	// Token: 0x06005F6E RID: 24430 RVA: 0x00294860 File Offset: 0x00292A60
	private static cde a(string A_0, Gender A_1, string A_2)
	{
		cde cde = bz9.a(A_0, A_1, false, true, A_2, 0, null, false);
		cde.c[CharacterState.Custom1] = cde.c[CharacterState.Idle];
		cde.a[CharacterState.Custom1.ToString()] = 8;
		return cde;
	}

	// Token: 0x06005F6F RID: 24431 RVA: 0x002948B4 File Offset: 0x00292AB4
	private static cde a(string A_0, Gender A_1, bool A_2, bool A_3 = true, string A_4 = null, int A_5 = 0, Dictionary<CharacterState, int> A_6 = null, bool A_7 = false)
	{
		cde cde = new cde();
		cde.h = new Point(-25, 0);
		cde.i = new Point(10, 0);
		if (A_1 == Gender.Male)
		{
			cde.k = 110;
		}
		else
		{
			cde.k = 105;
		}
		cde.k += A_5;
		cde.d = A_0;
		if (!string.IsNullOrEmpty(A_4))
		{
			cde.e = A_4;
		}
		else if (A_7)
		{
			cde.e = "HumanNew";
		}
		else
		{
			cde.e = ((A_1 == Gender.Female) ? "Human_Female" : "Human");
		}
		cde.f = A_2;
		cde.g = A_3;
		cde.c[CharacterState.Idle] = new float?(0.95f);
		cde.c[CharacterState.Stunned] = new float?(0.95f);
		cde.c[CharacterState.Operating] = new float?(0.95f);
		cde.c[CharacterState.Die] = new float?(0.95f);
		cde.c[CharacterState.Move] = new float?(1f);
		cde.c[CharacterState.ChannelPsi] = new float?(1.05f);
		cde.c[CharacterState.CastingPsi] = new float?(1.05f);
		cde.c[CharacterState.Throw] = new float?(1.05f);
		cde.c[CharacterState.OperateShort] = new float?(0.95f);
		cde.c[CharacterState.FinishPsi] = new float?(1.05f);
		cde.c[CharacterState.Attack1] = new float?(1.05f);
		cde.c[CharacterState.Attack2] = new float?(1.05f);
		cde.c[CharacterState.RaiseWeapon] = new float?(1.05f);
		cde.c[CharacterState.LowerWeapon] = new float?(1.05f);
		cde.c[CharacterState.ShieldBash] = new float?(1.05f);
		cde.c[CharacterState.Custom1] = new float?(0.95f);
		cde.c[CharacterState.Custom2] = new float?(0.95f);
		cde.c[CharacterState.Custom3] = new float?(0.95f);
		cde.c[CharacterState.Custom4] = new float?(0.95f);
		cde.c[CharacterState.Custom5] = new float?(0.95f);
		cde.c[CharacterState.Custom6] = new float?(0.95f);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Operating.ToString()] = 6;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.ChannelPsi.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 7;
		cde.a[CharacterState.Throw.ToString()] = 7;
		cde.a[CharacterState.OperateShort.ToString()] = 3;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.ShieldBash.ToString()] = 6;
		cde.a[CharacterState.Custom1.ToString()] = 10;
		cde.a[CharacterState.Custom2.ToString()] = 7;
		cde.a[CharacterState.Custom3.ToString()] = 7;
		cde.a[CharacterState.Custom4.ToString()] = 7;
		cde.a[CharacterState.Custom5.ToString()] = 10;
		cde.a[CharacterState.Custom6.ToString()] = 10;
		foreach (string str in an3.u)
		{
			cde.a[CharacterState.Custom1.ToString() + str] = 10;
		}
		if (A_6 != null)
		{
			foreach (KeyValuePair<CharacterState, int> keyValuePair in A_6)
			{
				cde.c[keyValuePair.Key] = new float?(0.95f);
				cde.a[keyValuePair.Key.ToString()] = keyValuePair.Value;
			}
		}
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.a] = 6;
		cde.a[CharacterState.Attack2.ToString() + an3.a] = 6;
		cde.a[CharacterState.Attack1.ToString() + an3.b] = 6;
		cde.a[CharacterState.Attack2.ToString() + an3.b] = 6;
		cde.a[CharacterState.Attack1.ToString() + an3.c] = 10;
		cde.a[CharacterState.Attack2.ToString() + an3.c] = 10;
		cde.a[CharacterState.Attack1.ToString() + an3.k] = 8;
		cde.a[CharacterState.Attack2.ToString() + an3.k] = 8;
		cde.a[CharacterState.Attack1.ToString() + an3.l] = 8;
		cde.a[CharacterState.Attack2.ToString() + an3.l] = 6;
		cde.a[CharacterState.Attack1.ToString() + an3.d] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.d] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.d] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.e] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.e] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.e] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.f] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.f] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.f] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.g] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.g] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.g] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.h] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.h] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.h] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.i] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.i] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.i] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.m] = 20;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.m] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.m] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.n] = 5;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.n] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.n] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.j] = 5;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.j] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.j] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.q] = 5;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.q] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.q] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.o] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.o] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.o] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.p] = 8;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.p] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.p] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.r] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.r] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.r] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.s] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.s] = 9;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.s] = 9;
		cde.a[CharacterState.Attack1.ToString() + an3.t] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.t] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.t] = 5;
		return cde;
	}

	// Token: 0x06005F70 RID: 24432 RVA: 0x00295664 File Offset: 0x00293864
	private static cde a(string A_0, Gender A_1, bool A_2 = false, bool A_3 = false)
	{
		cde cde = new cde();
		cde.h = new Point(-25, 0);
		cde.i = new Point(10, 0);
		cde.k = 110;
		cde.d = A_0;
		if (A_2)
		{
			cde.e = "Xpbl_BigJetski";
		}
		else
		{
			cde.e = "Xpbl_Jetski";
		}
		cde.g = true;
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Operating.ToString()] = 6;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.ChannelPsi.ToString()] = 8;
		cde.a[CharacterState.CastingPsi.ToString()] = 7;
		cde.a[CharacterState.Throw.ToString()] = 7;
		cde.a[CharacterState.OperateShort.ToString()] = 3;
		cde.a[CharacterState.FinishPsi.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 8;
		cde.a[CharacterState.Custom2.ToString()] = 8;
		cde.a[CharacterState.Custom3.ToString()] = 8;
		cde.a[CharacterState.Custom6.ToString()] = 1;
		cde.b[CharacterState.Attack2] = CharacterState.Attack1;
		foreach (string str in an3.u)
		{
			cde.a[CharacterState.Custom6.ToString() + str] = 1;
		}
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.a] = 6;
		cde.a[CharacterState.Attack2.ToString() + an3.a] = 6;
		cde.a[CharacterState.Attack1.ToString() + an3.b] = 6;
		cde.a[CharacterState.Attack2.ToString() + an3.b] = 6;
		cde.a[CharacterState.Attack1.ToString() + an3.c] = 10;
		cde.a[CharacterState.Attack2.ToString() + an3.c] = 10;
		cde.a[CharacterState.Attack1.ToString() + an3.k] = 8;
		cde.a[CharacterState.Attack2.ToString() + an3.k] = 8;
		cde.a[CharacterState.Attack1.ToString() + an3.l] = 8;
		cde.a[CharacterState.Attack2.ToString() + an3.l] = 6;
		cde.a[CharacterState.Attack1.ToString() + an3.d] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.d] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.d] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.e] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.e] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.e] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.f] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.f] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.f] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.g] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.g] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.g] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.h] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.h] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.h] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.i] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.i] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.i] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.m] = (A_3 ? 11 : 12);
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.m] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.m] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.n] = 5;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.n] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.n] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.j] = 5;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.j] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.j] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.q] = 5;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.q] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.q] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.o] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.o] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.o] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.p] = 5;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.p] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.p] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.r] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.r] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.r] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.s] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.s] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.s] = 5;
		cde.a[CharacterState.Attack1.ToString() + an3.t] = 3;
		cde.a[CharacterState.RaiseWeapon.ToString() + an3.t] = 5;
		cde.a[CharacterState.LowerWeapon.ToString() + an3.t] = 5;
		return cde;
	}

	// Token: 0x06005F71 RID: 24433 RVA: 0x0029611C File Offset: 0x0029431C
	private static cde c(float A_0)
	{
		cde cde = new cde();
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(1.05f * A_0);
		cde.c[CharacterState.Die] = new float?(1.05f * A_0);
		cde.c[CharacterState.Move] = new float?(1.1f * A_0);
		cde.c[CharacterState.FinishPsi] = new float?(1.15f * A_0);
		cde.c[CharacterState.Attack1] = new float?(1.15f * A_0);
		cde.c[CharacterState.Attack2] = new float?(1.15f * A_0);
		cde.c[CharacterState.Stunned] = new float?(1.05f * A_0);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 10;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 6;
		cde.a[CharacterState.Attack2.ToString()] = 7;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 7;
		cde.b[CharacterState.Operating] = CharacterState.Attack2;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Idle;
		cde.b[CharacterState.CastingPsi] = CharacterState.Idle;
		cde.b[CharacterState.Throw] = CharacterState.Attack2;
		cde.b[CharacterState.OperateShort] = CharacterState.Attack2;
		return cde;
	}

	// Token: 0x06005F72 RID: 24434 RVA: 0x002962EC File Offset: 0x002944EC
	private static cde b(float A_0)
	{
		cde cde = new cde();
		cde.f = false;
		cde.g = false;
		cde.c[CharacterState.Idle] = new float?(0.9f * A_0);
		cde.c[CharacterState.Die] = new float?(0.9f * A_0);
		cde.c[CharacterState.Move] = new float?(0.9f * A_0);
		cde.c[CharacterState.FinishPsi] = new float?(1f * A_0);
		cde.c[CharacterState.Attack1] = new float?(1f * A_0);
		cde.c[CharacterState.Attack2] = new float?(1f * A_0);
		cde.c[CharacterState.Stunned] = new float?(0.9f * A_0);
		cde.c[CharacterState.Custom1] = new float?(0.9f * A_0);
		cde.c[CharacterState.Custom2] = new float?(0.9f * A_0);
		cde.c[CharacterState.Custom3] = new float?(0.9f * A_0);
		cde.a[CharacterState.Idle.ToString()] = 10;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 7;
		cde.a[CharacterState.Attack2.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 6;
		cde.a[CharacterState.Custom1.ToString()] = 11;
		cde.a[CharacterState.Custom2.ToString()] = 8;
		cde.a[CharacterState.Custom3.ToString()] = 18;
		cde.b[CharacterState.Operating] = CharacterState.Custom2;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Custom1;
		return cde;
	}

	// Token: 0x06005F73 RID: 24435 RVA: 0x0029655C File Offset: 0x0029475C
	private static cde a(float A_0)
	{
		cde cde = new cde();
		cde.f = false;
		cde.g = false;
		cde.e = "Xpbl_Buffalo";
		cde.c[CharacterState.Idle] = new float?(0.9f * A_0);
		cde.c[CharacterState.Die] = new float?(0.9f * A_0);
		cde.c[CharacterState.Move] = new float?(0.9f * A_0);
		cde.c[CharacterState.FinishPsi] = new float?(0.9f * A_0);
		cde.c[CharacterState.Attack1] = new float?(0.9f * A_0);
		cde.c[CharacterState.Attack2] = new float?(0.9f * A_0);
		cde.c[CharacterState.Stunned] = new float?(0.9f * A_0);
		cde.c[CharacterState.Custom1] = new float?(0.9f * A_0);
		cde.c[CharacterState.Custom2] = new float?(0.9f * A_0);
		cde.c[CharacterState.Custom3] = new float?(0.9f * A_0);
		cde.c[CharacterState.Custom4] = new float?(0.9f * A_0);
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Attack2.ToString()] = 6;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.FinishPsi.ToString()] = 6;
		cde.a[CharacterState.Custom1.ToString()] = 11;
		cde.a[CharacterState.Custom2.ToString()] = 8;
		cde.a[CharacterState.Custom3.ToString()] = 13;
		cde.a[CharacterState.Custom4.ToString()] = 8;
		cde.b[CharacterState.Operating] = CharacterState.Custom2;
		cde.b[CharacterState.ChannelPsi] = CharacterState.Attack1;
		cde.b[CharacterState.CastingPsi] = CharacterState.Attack1;
		cde.b[CharacterState.Throw] = CharacterState.Attack1;
		cde.b[CharacterState.OperateShort] = CharacterState.Custom1;
		return cde;
	}

	// Token: 0x06005F74 RID: 24436 RVA: 0x0029680C File Offset: 0x00294A0C
	private static cde a(float A_0, bool A_1)
	{
		cde cde = new cde();
		cde.f = false;
		cde.g = false;
		cde.e = "Xpbl_Strider";
		cde.c[CharacterState.Idle] = new float?(0.7f * A_0);
		cde.c[CharacterState.Die] = new float?(0.7f * A_0);
		cde.c[CharacterState.Move] = new float?(0.7f * A_0);
		cde.c[CharacterState.Attack1] = new float?(0.7f * A_0);
		cde.c[CharacterState.Attack2] = new float?(0.7f * A_0);
		cde.c[CharacterState.Stunned] = new float?(0.7f * A_0);
		cde.c[CharacterState.Custom1] = new float?(0.7f * A_0);
		if (A_1)
		{
			cde.c[CharacterState.Custom2] = new float?(0.7f * A_0);
		}
		cde.a[CharacterState.Idle.ToString()] = 8;
		cde.a[CharacterState.Die.ToString()] = 9;
		cde.a[CharacterState.Move.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 8;
		cde.a[CharacterState.Attack2.ToString()] = 5;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 8;
		if (A_1)
		{
			cde.a[CharacterState.Custom2.ToString()] = 8;
		}
		return cde;
	}

	// Token: 0x06005F75 RID: 24437 RVA: 0x002969E8 File Offset: 0x00294BE8
	private static cde a(string A_0, int A_1)
	{
		cde cde = bz9.a(A_0, Gender.Male, false, true, "Xpbl_Skerder", 10, null, false);
		cde.a[CharacterState.FinishPsi.ToString()] = 10;
		foreach (CharacterState key in new CharacterState[]
		{
			CharacterState.Custom1,
			CharacterState.Custom2,
			CharacterState.Custom3,
			CharacterState.Custom4,
			CharacterState.Custom5
		})
		{
			cde.a[key.ToString()] = A_1;
			cde.c[key] = new float?(1.05f);
		}
		return cde;
	}

	// Token: 0x06005F76 RID: 24438 RVA: 0x00296A8C File Offset: 0x00294C8C
	private static cde a(string A_0)
	{
		cde cde = new cde();
		cde.d = A_0;
		cde.e = "Xpbl_MachineGunTurret";
		cde.k = 95;
		cde.f = false;
		cde.g = false;
		cde.a[CharacterState.Idle.ToString()] = 1;
		cde.a[CharacterState.Die.ToString()] = 8;
		cde.a[CharacterState.Attack1.ToString()] = 4;
		cde.a[CharacterState.Stunned.ToString()] = 8;
		cde.a[CharacterState.Custom1.ToString()] = 1;
		cde.c[CharacterState.Idle] = new float?(1f);
		cde.c[CharacterState.Die] = new float?(1f);
		cde.c[CharacterState.Attack1] = new float?(1f);
		cde.c[CharacterState.Stunned] = new float?(1f);
		cde.c[CharacterState.Custom1] = new float?(1f);
		return cde;
	}

	// Token: 0x040025EF RID: 9711
	internal static Dictionary<CharacterState, string> a;

	// Token: 0x040025F0 RID: 9712
	public static Dictionary<string, cde> b = new Dictionary<string, cde>();
}
