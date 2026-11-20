using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Game.Data;

// Token: 0x02000551 RID: 1361
public class eeo : e5f
{
	// Token: 0x060022CF RID: 8911 RVA: 0x000B8B40 File Offset: 0x000B6D40
	public c1a ar9()
	{
		return this.b;
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x000B8B48 File Offset: 0x000B6D48
	public List<GlobalMap> asa()
	{
		return this.e;
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x000B8B50 File Offset: 0x000B6D50
	public Dictionary<GlobalMap, string> asb()
	{
		return this.f;
	}

	// Token: 0x060022D2 RID: 8914 RVA: 0x000B8B58 File Offset: 0x000B6D58
	public Dictionary<string, GlobalMap> asc()
	{
		return this.g;
	}

	// Token: 0x060022D3 RID: 8915 RVA: 0x000B8B64 File Offset: 0x000B6D64
	public eeo()
	{
		this.f = new Dictionary<GlobalMap, string>();
		this.f[GlobalMap.LowerCaves] = "lc";
		this.f[GlobalMap.SouthGateStation] = "sgs";
		this.f[GlobalMap.LowerUnderrail] = "lu";
		this.f[GlobalMap.UpperCaves] = "lux";
		this.f[GlobalMap.LowerPassages] = "lup";
		this.f[GlobalMap.UpperUnderrail] = "up";
		this.f[GlobalMap.Foundry] = "fo";
		this.f[GlobalMap.DeepCaverns] = "dc";
		this.f[GlobalMap.Unknown] = "un";
		this.f[GlobalMap.BlackSea] = "bs";
		this.g = new Dictionary<string, GlobalMap>();
		this.g["lc"] = GlobalMap.LowerCaves;
		this.g["sgs"] = GlobalMap.SouthGateStation;
		this.g["lu"] = GlobalMap.LowerUnderrail;
		this.g["lux"] = GlobalMap.UpperCaves;
		this.g["lup"] = GlobalMap.LowerPassages;
		this.g["up"] = GlobalMap.UpperUnderrail;
		this.g["fo"] = GlobalMap.Foundry;
		this.g["dc"] = GlobalMap.DeepCaverns;
		this.g["un"] = GlobalMap.Unknown;
		this.g["bs"] = GlobalMap.BlackSea;
		this.e = new List<GlobalMap>();
		this.e.Add(GlobalMap.SouthGateStation);
		this.e.Add(GlobalMap.Foundry);
		this.e.Add(GlobalMap.UpperUnderrail);
		this.e.Add(GlobalMap.LowerUnderrail);
		this.e.Add(GlobalMap.LowerPassages);
		this.e.Add(GlobalMap.UpperCaves);
		this.e.Add(GlobalMap.LowerCaves);
		this.e.Add(GlobalMap.BlackSea);
		this.e.Add(GlobalMap.DeepCaverns);
		this.e.Add(GlobalMap.Unknown);
	}

	// Token: 0x060022D4 RID: 8916 RVA: 0x000B8D74 File Offset: 0x000B6F74
	public void c()
	{
		this.a();
	}

	// Token: 0x060022D5 RID: 8917 RVA: 0x000B8D80 File Offset: 0x000B6F80
	public void b()
	{
		this.d.Clear();
		foreach (aud aud in this.b.Areas)
		{
			foreach (b0b b0b in aud.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (!c5x.IsFloor)
				{
					c5x.ae = new float?(0f);
				}
			}
		}
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x000B8E44 File Offset: 0x000B7044
	public void asd()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		this.b();
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			d60 addon = this.b.GetAddon<d60>();
			List<b0b> list = addon.ab4(new string[]
			{
				"ZoneMapNode"
			});
			if (list != null)
			{
				this.asl(list);
			}
			List<b0b> list2 = addon.ab4(new string[]
			{
				"TransitionMapNode"
			});
			if (list2 != null)
			{
				this.asm(list2);
			}
		}
		stopwatch.Stop();
		Trace.WriteLine("Adjusting global map took: " + stopwatch.Elapsed.ToString());
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x000B8EE8 File Offset: 0x000B70E8
	public bool ase(string A_0)
	{
		List<b0b> list = this.b.GetAddon<d60>().ab4(new string[]
		{
			string.Format("LocaleRepresenter_{0}", A_0.ToLowerInvariant()),
			string.Format("LocaleContainer_{0}", A_0.ToLowerInvariant())
		});
		return list != null && list.Count > 0;
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x000B8F44 File Offset: 0x000B7144
	public void asf(string A_0)
	{
		List<b0b> list = this.b.GetAddon<d60>().ab4(new string[]
		{
			string.Format("LocaleRepresenter_{0}", A_0.ToLowerInvariant()),
			string.Format("LocaleContainer_{0}", A_0.ToLowerInvariant())
		});
		if (list != null)
		{
			this.asl(list);
		}
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x000B8F9C File Offset: 0x000B719C
	public void asg(string A_0, string A_1)
	{
		d60 addon = this.b.GetAddon<d60>();
		string arg = dfz.a(A_0, A_1);
		List<b0b> list = addon.ab4(new string[]
		{
			string.Format("TransitionRepresenter_{0}", arg)
		});
		if (list != null)
		{
			this.asm(list);
		}
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x000B8FE4 File Offset: 0x000B71E4
	public void ash(string A_0, string A_1 = null)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().c(A_0, A_1);
		}
	}

	// Token: 0x060022DB RID: 8923 RVA: 0x000B9010 File Offset: 0x000B7210
	public List<string> asi(b0b A_0)
	{
		List<string> list = new List<string>();
		if (A_0 != null)
		{
			HashSet<b0b> hashSet = new HashSet<b0b>();
			foreach (ak1 ak in A_0.l)
			{
				foreach (b0b b0b in ak.c.Values)
				{
					c5x c5x = (c5x)b0b;
					if (!c5x.IsFloor && c5x != A_0 && !hashSet.Contains(c5x))
					{
						hashSet.Add(c5x);
						if (Math.Abs(A_0.Location.Z - c5x.Location.Z) < 1f)
						{
							Vector3 vector = c5x.aj();
							if (vector.X >= A_0.Location.X && vector.X < A_0.Location.X + A_0.Size.X && vector.Y >= A_0.Location.Y && vector.Y < A_0.Location.Y + A_0.Size.Y)
							{
								em7 aspect = c5x.GetAspect<em7>();
								if (aspect != null && !string.IsNullOrEmpty(aspect.a()) && aspect.b() == MapNodeState.Revealed && !list.Contains(aspect.a()))
								{
									list.Add(aspect.a());
								}
							}
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060022DC RID: 8924 RVA: 0x000B91F8 File Offset: 0x000B73F8
	public bool asj(b0b A_0)
	{
		djr aspect = A_0.GetAspect<djr>();
		if (aspect != null && !string.IsNullOrWhiteSpace(aspect.b()))
		{
			aud aud = this.b.n(aspect.b());
			if (aud != null)
			{
				b0b b0b = aud.a(aspect.d());
				if (b0b != null)
				{
					dy9 aspect2 = b0b.GetAspect<dy9>();
					if (aspect2 != null && aspect2.a() != MapNodeState.Obscured)
					{
						return true;
					}
					ay0 aspect3 = b0b.GetAspect<ay0>();
					if (aspect3 != null && aspect3.a() != MapNodeState.Obscured)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060022DD RID: 8925 RVA: 0x000B9288 File Offset: 0x000B7488
	public bool ask(GlobalMap A_0)
	{
		return this.d.Contains(A_0);
	}

	// Token: 0x060022DE RID: 8926 RVA: 0x000B9298 File Offset: 0x000B7498
	public void asl(List<b0b> A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		foreach (b0b b0b in A_0)
		{
			c5x c5x = (c5x)b0b;
			HashSet<string> hashSet = new HashSet<string>();
			dy9 aspect = c5x.GetAspect<dy9>();
			if (aspect != null)
			{
				aspect.a(aspect.e());
				foreach (string a_ in Enumerable.Union<string>(aspect.b(), aspect.f()))
				{
					bfc bfc = serviceOrThrow.ar0(a_, serviceOrThrow.aqu());
					if (bfc != null)
					{
						alg alg = serviceOrThrow.aqu().a(bfc.Id, false);
						if (alg != null)
						{
							foreach (string text in alg.c)
							{
								hashSet.Add(text);
							}
							if (aspect.a() != MapNodeState.Revealed)
							{
								if (alg.a)
								{
									aspect.a(MapNodeState.Revealed);
								}
								else if (alg.b)
								{
									aspect.a(MapNodeState.Shadowed);
								}
							}
						}
					}
				}
				if (aspect.a() != MapNodeState.Obscured && this.asc().ContainsKey(aspect.a8().Area.y8()))
				{
					this.a(this.asc()[aspect.a8().Area.y8()]);
				}
				if (aspect.a() == MapNodeState.Shadowed)
				{
					this.a(c5x, MapNodeState.Shadowed);
				}
				else if (aspect.a() == MapNodeState.Revealed)
				{
					HashSet<b0b> hashSet2 = new HashSet<b0b>();
					this.a(c5x, MapNodeState.Revealed);
					foreach (ak1 ak in c5x.l)
					{
						foreach (b0b b0b2 in ak.c.Values)
						{
							c5x c5x2 = (c5x)b0b2;
							if (!c5x2.IsFloor && c5x2 != c5x && !hashSet2.Contains(c5x2))
							{
								hashSet2.Add(c5x2);
								if (Math.Abs(c5x.Location.Z - c5x2.Location.Z) < 1f)
								{
									Vector3 vector = c5x2.aj();
									if (vector.X >= c5x.Location.X && vector.X < c5x.Location.X + c5x.Size.X && vector.Y >= c5x.Location.Y && vector.Y < c5x.Location.Y + c5x.Size.Y && c5x2.GetAspect<ay0>() == null)
									{
										em7 aspect2 = c5x2.GetAspect<em7>();
										if (aspect2 != null)
										{
											bool flag = true;
											foreach (string text2 in aspect2.e())
											{
												if (!hashSet.Contains(text2))
												{
													flag = false;
													break;
												}
											}
											if (flag)
											{
												foreach (string text3 in aspect2.d())
												{
													if (hashSet.Contains(text3))
													{
														flag = false;
														break;
													}
												}
											}
											if (flag)
											{
												if (aspect.a() == MapNodeState.Revealed)
												{
													this.a(c5x2, MapNodeState.Revealed);
													aspect2.a(MapNodeState.Revealed);
												}
												else
												{
													this.a(c5x2, MapNodeState.Shadowed);
													aspect2.a(MapNodeState.Shadowed);
												}
											}
											else
											{
												this.a(c5x2, MapNodeState.Obscured);
												aspect2.a(MapNodeState.Obscured);
											}
										}
										else
										{
											this.a(c5x2, aspect.a());
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060022DF RID: 8927 RVA: 0x000B97A0 File Offset: 0x000B79A0
	public void asm(List<b0b> A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			foreach (b0b b0b in A_0)
			{
				c5x c5x = (c5x)b0b;
				ay0 aspect = c5x.GetAspect<ay0>();
				if (aspect != null)
				{
					bool flag = false;
					aspect.a(aspect.e());
					foreach (string text in aspect.b())
					{
						foreach (string text2 in aspect.d())
						{
							if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(text2))
							{
								eaj eaj = serviceOrThrow.aqu().a(text, text2, false);
								if (eaj != null)
								{
									if (eaj.a)
									{
										aspect.a(MapNodeState.Revealed);
										flag = true;
									}
									else if (eaj.b)
									{
										aspect.a(MapNodeState.Shadowed);
									}
								}
							}
							if (flag)
							{
								break;
							}
						}
						if (flag)
						{
							break;
						}
					}
					this.a(c5x, aspect.a());
				}
			}
		}
	}

	// Token: 0x060022E0 RID: 8928 RVA: 0x000B9954 File Offset: 0x000B7B54
	public void asn(e6d A_0)
	{
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x000B9958 File Offset: 0x000B7B58
	public void aso()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		foreach (aud aud in this.b.Areas)
		{
			foreach (b0b b0b in aud.Entities)
			{
				c5x c5x = (c5x)b0b;
				c5x.ae = null;
				dy9 aspect = c5x.GetAspect<dy9>();
				if (aspect != null && aspect.a() != MapNodeState.Revealed && aspect.b().Count > 0)
				{
					serviceOrThrow.aqu().a(Enumerable.First<string>(aspect.b()), true).a = true;
					this.asf(Enumerable.First<string>(aspect.b()));
				}
				ay0 aspect2 = c5x.GetAspect<ay0>();
				if (aspect2 != null)
				{
					foreach (string text in aspect2.b())
					{
						foreach (string text2 in aspect2.d())
						{
							if (aspect2.a() != MapNodeState.Revealed && !string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(text2))
							{
								serviceOrThrow.aqu().b(text, text2);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x000B9B5C File Offset: 0x000B7D5C
	private void a(c5x A_0, MapNodeState A_1)
	{
		if (A_0.o.b != null)
		{
			if (A_1 == MapNodeState.Obscured)
			{
				A_0.ae = new float?(0f);
				return;
			}
			A_0.ae = null;
			string text = A_0.o.b.a;
			int num = text.IndexOf("_");
			if (A_1 == MapNodeState.Revealed && num != -1)
			{
				text = text.Substring(0, num);
			}
			else if (A_1 == MapNodeState.Shadowed && num == -1)
			{
				text += "_Desaturated";
			}
			A_0.o.b.a = text;
		}
	}

	// Token: 0x060022E3 RID: 8931 RVA: 0x000B9C00 File Offset: 0x000B7E00
	private void a()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		if (this.c == null)
		{
			d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
			d4p a_ = new d4p(true);
			etb a_2 = new etb();
			this.c = new e3h(eeo.a, a_, a_2);
			serviceOrThrow.dz(this.c);
		}
		if (this.b == null)
		{
			string a_3 = Path.Combine(Path.Combine(dr3.d().lf(), d5x.r), "GlobalMap.uz");
			this.b = c1a.a(a_3);
			this.b.AttachAddon<d60>(new bwy());
			this.c.a(this.b);
			this.b.bc(true);
		}
		stopwatch.Stop();
		Trace.WriteLine("Global map initialization took: " + stopwatch.Elapsed.ToString());
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x000B9CDC File Offset: 0x000B7EDC
	private void a(GlobalMap A_0)
	{
		if (!this.d.Contains(A_0))
		{
			this.d.Add(A_0);
			dpp service = bpo.GetService<dpp>();
			if (service != null)
			{
				service.va();
			}
		}
	}

	// Token: 0x04001489 RID: 5257
	public static readonly string a = "GlobalPlayfield";

	// Token: 0x0400148A RID: 5258
	public c1a b;

	// Token: 0x0400148B RID: 5259
	public e3h c;

	// Token: 0x0400148C RID: 5260
	public HashSet<GlobalMap> d = new HashSet<GlobalMap>();

	// Token: 0x0400148D RID: 5261
	public readonly List<GlobalMap> e;

	// Token: 0x0400148E RID: 5262
	public readonly Dictionary<GlobalMap, string> f;

	// Token: 0x0400148F RID: 5263
	public readonly Dictionary<string, GlobalMap> g;
}
