using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x0200128D RID: 4749
[eiz("SCDCEA0")]
[Serializable]
public sealed class cbp : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x06006759 RID: 26457 RVA: 0x002BD104 File Offset: 0x002BB304
	private cbp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetString("SCDCEA0:P");
		this.d = A_0.GetString("SCDCEA0:A");
		this.e = A_0.GetString("SCDCEA0:R");
		di7.ReadList<d7>("SCDCEA0:D", ref this.f, A_0);
		this.g = A_0.GetBoolean("SCDCEA0:C");
		this.h = A_0.GetDouble("SCDCEA0:T");
	}

	// Token: 0x0600675A RID: 26458 RVA: 0x002BD18C File Offset: 0x002BB38C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCDCEA0:P", this.c);
		info.AddValue("SCDCEA0:A", this.d);
		info.AddValue("SCDCEA0:R", this.e);
		di7.WriteList<d7>("SCDCEA0:D", this.f, info);
		info.AddValue("SCDCEA0:C", this.g);
		info.AddValue("SCDCEA0:T", this.h);
	}

	// Token: 0x0600675B RID: 26459 RVA: 0x002BD208 File Offset: 0x002BB408
	public string e()
	{
		return this.c;
	}

	// Token: 0x0600675C RID: 26460 RVA: 0x002BD210 File Offset: 0x002BB410
	public void c(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600675D RID: 26461 RVA: 0x002BD21C File Offset: 0x002BB41C
	public string d()
	{
		return this.d;
	}

	// Token: 0x0600675E RID: 26462 RVA: 0x002BD224 File Offset: 0x002BB424
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600675F RID: 26463 RVA: 0x002BD230 File Offset: 0x002BB430
	public string g()
	{
		return this.e;
	}

	// Token: 0x06006760 RID: 26464 RVA: 0x002BD238 File Offset: 0x002BB438
	public void d(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006761 RID: 26465 RVA: 0x002BD244 File Offset: 0x002BB444
	public List<d7> f()
	{
		return this.f;
	}

	// Token: 0x06006762 RID: 26466 RVA: 0x002BD24C File Offset: 0x002BB44C
	public void a(List<d7> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006764 RID: 26468 RVA: 0x002BD314 File Offset: 0x002BB514
	public cbp(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006765 RID: 26469 RVA: 0x002BD328 File Offset: 0x002BB528
	public void r7(eds A_0)
	{
		if ((this.h += A_0.b.TotalMilliseconds) >= (double)cbp.a)
		{
			this.h -= (double)cbp.a;
			this.b();
		}
	}

	// Token: 0x06006766 RID: 26470 RVA: 0x002BD374 File Offset: 0x002BB574
	private void b()
	{
		if (!string.IsNullOrEmpty(this.d) && base.a8() != null && base.a8().Zone != null)
		{
			d60 d = base.a8().Zone.a();
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (d != null && serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(this.d, new bool?(false)).Value;
				List<b0b> list = d.ab4(new string[]
				{
					this.e
				});
				if (list.Count > 0)
				{
					if (value)
					{
						List<a98> list2 = new List<a98>(this.a());
						List<b0b> list3 = new List<b0b>(list);
						foreach (b0b b0b in list)
						{
							bm6 aspect = b0b.GetAspect<bm6>();
							if (aspect != null)
							{
								string classPropertyValue = aspect.y6().GetClassPropertyValue<string>(ddq.bw);
								if (!string.IsNullOrEmpty(classPropertyValue))
								{
									foreach (a98 a in list2)
									{
										if (a.a == classPropertyValue)
										{
											list2.Remove(a);
											list3.Remove(b0b);
											break;
										}
									}
								}
							}
						}
						List<a98> list4 = new List<a98>(list2);
						List<a98> list5 = new List<a98>();
						foreach (d7 d2 in this.f)
						{
							for (int i = 0; i < list4.Count; i++)
							{
								if (list4[i].c == d2.e())
								{
									list5.Add(list4[i]);
									list4.RemoveAt(i);
									i--;
								}
							}
						}
						using (List<a98>.Enumerator enumerator2 = list5.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								a98 a2 = enumerator2.Current;
								d7 d3 = this.a(a2.c);
								if (d3 != null)
								{
									List<b0b> list6;
									if (this.g)
									{
										cbp.a a3 = new cbp.a();
										a3.a = this.a(a2);
										list6 = Enumerable.ToList<b0b>(Enumerable.OrderBy<b0b, double>(list3, new Func<b0b, double>(a3.a)));
									}
									else
									{
										list6 = new List<b0b>();
										List<b0b> list7 = new List<b0b>(list3);
										while (list7.Count > 0)
										{
											int index = cuo.a.Next(list7.Count);
											list6.Add(list7[index]);
											list7.RemoveAt(index);
										}
									}
									List<b0b> list8 = new List<b0b>(list6);
									List<b0b> list9 = new List<b0b>();
									if (d3.c().Count > 0)
									{
										foreach (string a_ in d3.c())
										{
											for (int j = 0; j < list8.Count; j++)
											{
												c5x c5x = list8[j] as c5x;
												if (c5x.a(a_))
												{
													list9.Add(c5x);
													list8.RemoveAt(j);
													j--;
												}
											}
										}
									}
									if (!d3.a())
									{
										list9.AddRange(list8);
									}
									if (list9.Count > 0)
									{
										c5x c5x2 = list9[0] as c5x;
										this.a(c5x2, a2, d3);
										list3.Remove(c5x2);
									}
								}
							}
							return;
						}
					}
					foreach (b0b b0b2 in list)
					{
						c5x a_2 = (c5x)b0b2;
						this.a(a_2);
					}
				}
			}
		}
	}

	// Token: 0x06006767 RID: 26471 RVA: 0x002BD838 File Offset: 0x002BBA38
	private void a(c5x A_0, a98 A_1, d7 A_2)
	{
		if (A_0 != null && A_0.t.b != null)
		{
			this.b(A_0.t.b, cbp.b);
			A_0.t.b.y6()[ddq.bw] = A_1.a;
			A_1.m8(A_0.t.b, A_2);
		}
	}

	// Token: 0x06006768 RID: 26472 RVA: 0x002BD8A4 File Offset: 0x002BBAA4
	private ak1 a(a98 A_0)
	{
		string a_;
		if (A_0 is ym)
		{
			a_ = A_0.a;
		}
		else
		{
			a_ = A_0.a + ":1";
		}
		csd csd = base.a8().Zone.g(a_);
		if (csd != null && csd.Tile != null)
		{
			return csd.Tile;
		}
		return base.a8().Area.b(0, 0);
	}

	// Token: 0x06006769 RID: 26473 RVA: 0x002BD918 File Offset: 0x002BBB18
	private d7 a(string A_0)
	{
		foreach (d7 d in this.f)
		{
			if (d.e() == A_0)
			{
				return d;
			}
		}
		return null;
	}

	// Token: 0x0600676A RID: 26474 RVA: 0x002BD988 File Offset: 0x002BBB88
	private void a(c5x A_0)
	{
		if (A_0.t.b != null && !string.IsNullOrEmpty(A_0.t.b.y6().GetClassPropertyValue<string>(ddq.bw)))
		{
			this.a(A_0.t.b, cbp.b);
			A_0.t.b.y6().RemoveProperty(ddq.bw);
		}
	}

	// Token: 0x0600676B RID: 26475 RVA: 0x002BD9FC File Offset: 0x002BBBFC
	private void b(bm6 A_0, string A_1)
	{
		object propertyValue = A_0.y6().GetPropertyValue(A_1);
		if (propertyValue != null)
		{
			A_0.y6().RemoveProperty(A_1);
			A_0.y6()["Predeployment_" + A_1] = propertyValue;
		}
	}

	// Token: 0x0600676C RID: 26476 RVA: 0x002BDA40 File Offset: 0x002BBC40
	private void b(bm6 A_0, params string[] A_1)
	{
		if (A_1 != null && A_1.Length != 0)
		{
			foreach (string a_ in A_1)
			{
				this.b(A_0, a_);
			}
		}
	}

	// Token: 0x0600676D RID: 26477 RVA: 0x002BDA80 File Offset: 0x002BBC80
	private void a(bm6 A_0, string A_1)
	{
		object propertyValue = A_0.y6().GetPropertyValue("Predeployment_" + A_1);
		A_0.y6().RemoveProperty("Predeployment_" + A_1);
		if (propertyValue != null)
		{
			A_0.y6()[A_1] = propertyValue;
			return;
		}
		A_0.y6().RemoveProperty(A_1);
	}

	// Token: 0x0600676E RID: 26478 RVA: 0x002BDADC File Offset: 0x002BBCDC
	private void a(bm6 A_0, params string[] A_1)
	{
		if (A_1 != null && A_1.Length != 0)
		{
			foreach (string a_ in A_1)
			{
				this.a(A_0, a_);
			}
		}
	}

	// Token: 0x0600676F RID: 26479 RVA: 0x002BDB1C File Offset: 0x002BBD1C
	private List<a98> a()
	{
		List<a98> list = new List<a98>();
		if (!string.IsNullOrEmpty(this.c) && base.a8() != null && base.a8().Zone != null)
		{
			foreach (csd csd in base.a8().Zone.Waypoints)
			{
				if (csd.Name != null && csd.Name.StartsWith(this.c))
				{
					string[] array = csd.Name.Split(new char[]
					{
						':'
					}, StringSplitOptions.RemoveEmptyEntries);
					string[] array2 = array[0].Split(new char[]
					{
						'_'
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array2.Length == 3)
					{
						string text = array2[2];
						string a_ = array[0];
						a98 a;
						if (array.Length > 1)
						{
							int num;
							int.TryParse(array[1], out num);
							em6 em = this.a(list, a_);
							if (em != null)
							{
								if (num > em.a)
								{
									em.a = num;
									continue;
								}
								continue;
							}
							else
							{
								a = new em6();
								((em6)a).a = num;
							}
						}
						else
						{
							a = new ym();
						}
						a.a = a_;
						a.c = array2[1];
						a.b = text;
						list.Add(a);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06006770 RID: 26480 RVA: 0x002BDCB8 File Offset: 0x002BBEB8
	private em6 a(List<a98> A_0, string A_1)
	{
		foreach (a98 a in A_0)
		{
			em6 em = a as em6;
			if (em != null && em.a == A_1)
			{
				return em;
			}
		}
		return null;
	}

	// Token: 0x04002ABD RID: 10941
	private static readonly int a = 2000;

	// Token: 0x04002ABE RID: 10942
	private static readonly string[] b = new string[]
	{
		ddq.k,
		ddq.l,
		ddq.n,
		ddq.o,
		ddq.p,
		ddq.q,
		ddq.r,
		ddq.s,
		ddq.t,
		ddq.u,
		ddq.v,
		ddq.ay,
		ddq.w,
		ddq.x,
		ddq.y,
		ddq.z,
		ddq.aa,
		ddq.ab
	};

	// Token: 0x04002ABF RID: 10943
	private string c;

	// Token: 0x04002AC0 RID: 10944
	private string d;

	// Token: 0x04002AC1 RID: 10945
	private string e;

	// Token: 0x04002AC2 RID: 10946
	private List<d7> f = new List<d7>();

	// Token: 0x04002AC3 RID: 10947
	private bool g;

	// Token: 0x04002AC4 RID: 10948
	private double h;

	// Token: 0x0200128E RID: 4750
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06006772 RID: 26482 RVA: 0x002BDD34 File Offset: 0x002BBF34
		internal double a(b0b A_0)
		{
			return aw1.a(A_0, this.a);
		}

		// Token: 0x04002AC5 RID: 10949
		public ak1 a;
	}
}
