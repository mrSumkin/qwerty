using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000ACD RID: 2765
[eiz("XPHWTWSJ")]
[Serializable]
public sealed class cqq : cze, ISerializable
{
	// Token: 0x06004079 RID: 16505 RVA: 0x00188344 File Offset: 0x00186544
	private cqq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("XPHWTWSJ:W", typeof(List<string>)) as List<string>);
	}

	// Token: 0x0600407A RID: 16506 RVA: 0x0018837C File Offset: 0x0018657C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWTWSJ:W", this.a);
	}

	// Token: 0x0600407B RID: 16507 RVA: 0x00188398 File Offset: 0x00186598
	public List<string> a()
	{
		return this.a;
	}

	// Token: 0x0600407C RID: 16508 RVA: 0x001883A0 File Offset: 0x001865A0
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600407D RID: 16509 RVA: 0x001883AC File Offset: 0x001865AC
	public cqq()
	{
	}

	// Token: 0x0600407E RID: 16510 RVA: 0x001883C0 File Offset: 0x001865C0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw().a() != null)
			{
				foreach (string text in this.a)
				{
					List<b0b> list = serviceOrThrow.aqw().a().ab4(new string[]
					{
						text
					});
					if (list != null)
					{
						foreach (b0b b0b in list)
						{
							c5x c5x = (c5x)b0b;
							e3l aspect = c5x.GetAspect<e3l>();
							if (aspect != null)
							{
								bool flag = false;
								using (List<string>.Enumerator enumerator3 = aspect.a.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										if (enumerator3.Current.Contains("ControlledBy_"))
										{
											flag = true;
										}
									}
								}
								if (!flag)
								{
									c5x.b("ControlledBy_" + A_1.y8());
								}
								if (c5x.a("ControlledBy_" + A_1.y8()))
								{
									ak1 ak = Enumerable.FirstOrDefault<ak1>(c5x.l);
									bool flag2 = true;
									foreach (b0b b0b2 in ak.Entities)
									{
										c5x c5x2 = (c5x)b0b2;
										if (c5x2.h != null && c5x2.h.b != null && c5x2.h.b.aa() != null)
										{
											flag2 = false;
											break;
										}
									}
									if (flag2)
									{
										this.b(c5x);
										this.a(c5x);
										if (c5x.a("passage"))
										{
											this.a(c5x, 11);
										}
										else
										{
											this.a(c5x, -1);
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

	// Token: 0x0600407F RID: 16511 RVA: 0x00188648 File Offset: 0x00186848
	private void b(c5x A_0)
	{
		ak1 ak = Enumerable.FirstOrDefault<ak1>(A_0.l);
		if (ak != null)
		{
			List<ya> list = ak.a(typeof(cos));
			if (list != null)
			{
				foreach (cos cos in Enumerable.OfType<cos>(list))
				{
					cos.a(A_0);
				}
			}
			dd5.b(ak);
			list = ak.a(typeof(ee7));
			if (list != null)
			{
				foreach (ya ya in list)
				{
					ee7 ee = (ee7)ya;
					ee.a().w();
					ee.a().an();
					ee.o();
				}
			}
			list = ak.a(typeof(ed0));
			if (list != null)
			{
				foreach (ya ya2 in list)
				{
					ed0 ed = (ed0)ya2;
					ed.a().ao().a8().w();
					ed.a().ao().a8().an();
					ed.o();
				}
			}
			list = ak.a(typeof(sl));
			if (list != null)
			{
				foreach (ya ya3 in list)
				{
					sl sl = (sl)ya3;
					sl.a().ao().a8().w();
					sl.a().ao().a8().an();
					sl.o();
				}
			}
			list = ak.a(typeof(s8));
			if (list != null)
			{
				foreach (ya ya4 in list)
				{
					s8 s = (s8)ya4;
					s.a().ao().a8().w();
					s.a().ao().a8().an();
					s.o();
				}
			}
		}
	}

	// Token: 0x06004080 RID: 16512 RVA: 0x001888D8 File Offset: 0x00186AD8
	private void a(c5x A_0)
	{
		ak1 ak = Enumerable.FirstOrDefault<ak1>(A_0.l);
		if (ak.Entities != null)
		{
			IList<b0b> list = ak.Entities;
			for (int i = 0; i < list.Count; i++)
			{
				c5x c5x = (c5x)list[i];
				if (c5x != null && c5x.s != null && c5x.s.b is c7j)
				{
					ak1 ak2 = Enumerable.FirstOrDefault<ak1>(aw1.b(c5x, true));
					if (ak2 != null)
					{
						c5x.Location = new Vector3((float)ak2.Location.X, (float)ak2.Location.Y, 0f);
						if (c5x != null)
						{
							c5x.ah();
						}
					}
				}
			}
		}
	}

	// Token: 0x06004081 RID: 16513 RVA: 0x00188998 File Offset: 0x00186B98
	public void a(c5x A_0, int A_1)
	{
		dtb dtb = new dtb();
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			ar7 a_ = new ar7(A_0);
			int num = A_0.o.b.b.Y;
			A_0.y8();
			if (num != A_1)
			{
				int num2 = 100;
				if (A_1 == -1)
				{
					num2 = cuo.a.Next(0, 3);
				}
				A_0.TileFormationModifiers.c();
				switch (num2)
				{
				case 0:
					A_1 = 11;
					A_0.VisualPriority = -1;
					A_0.IsFloor = true;
					break;
				case 1:
					A_1 = 6;
					A_0.VisualPriority = 1;
					A_0.TileFormationModifiers.s3(1);
					A_0.IsFloor = false;
					break;
				case 2:
					A_1 = 0;
					A_0.VisualPriority = 1;
					A_0.TileFormationModifiers.s3(1);
					A_0.TileFormationModifiers.s3(2);
					A_0.TileFormationModifiers.s3(0);
					A_0.IsFloor = false;
					break;
				default:
					A_1 = 11;
					A_0.VisualPriority = -1;
					A_0.IsFloor = true;
					break;
				}
				A_0.z();
				if (num != A_1)
				{
					List<auv> list = dtb.ad();
					bfq bfq = new bfq();
					bfq.c("Xphw_TrainingGroundsWall_Moving");
					a4s a4s = new a4s(bfq, null, null, null);
					a4s.b(a_);
					list.Add(a4s);
					do
					{
						if (num < A_1)
						{
							num++;
						}
						else
						{
							num--;
						}
						List<auv> list2 = dtb.ad();
						cm5 cm = new cm5();
						cm.a(num);
						a4s a4s2 = new a4s(cm, null, null, null);
						a4s2.b(a_);
						list2.Add(a4s2);
						dtb.ad().Add(new bm3(25));
					}
					while (num != A_1);
					A_0.Zone.ActionManager.g9(dtb, atp.a);
				}
			}
		}
	}

	// Token: 0x04001BFE RID: 7166
	private new List<string> a = new List<string>();
}
