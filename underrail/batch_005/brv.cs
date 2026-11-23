using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x0200167C RID: 5756
[eiz("FGRMH")]
[Serializable]
public sealed class brv : aig, ISerializable
{
	// Token: 0x06007D87 RID: 32135 RVA: 0x0034E730 File Offset: 0x0034C930
	private brv(SerializationInfo A_0, StreamingContext A_1)
	{
		this.b = (A_0.GetValue("FGRMH:S", typeof(ActionReference<qy>)) as ActionReference<qy>);
		this.c = (A_0.GetValue("FGRMH:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.a = A_0.GetSingle("FGRMH:D");
	}

	// Token: 0x06007D88 RID: 32136 RVA: 0x0034E794 File Offset: 0x0034C994
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("FGRMH:S", this.b);
		info.AddValue("FGRMH:A", this.c);
		info.AddValue("FGRMH:D", this.a);
	}

	// Token: 0x06007D89 RID: 32137 RVA: 0x0034E7CC File Offset: 0x0034C9CC
	public brv()
	{
	}

	// Token: 0x06007D8A RID: 32138 RVA: 0x0034E7D8 File Offset: 0x0034C9D8
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		this.a += A_3;
		if (this.a < 1.4f)
		{
			return false;
		}
		if (A_0 == null || A_0.Area == null || this.b == null || this.b.ao() == null || this.b.ao().x() != dc4.b)
		{
			return false;
		}
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		amc amc = null;
		if (this.c != null)
		{
			amc = this.c.ao();
		}
		ak1 ak = A_0.Area.a(A_0.aj().a());
		if (ak == null)
		{
			return false;
		}
		foreach (d4n d4n in serviceOrThrow.ahl())
		{
			if (d4n.b != null && d4n.b.aa().StatusEffects.a(bd9.a))
			{
				c5x c5x = d4n.b.a8();
				if (c5x.Area == A_0.Area)
				{
					double num = aw1.b(A_0, c5x);
					if (num > 1.0 && num <= 5.0 && (amc == null || d4n.b.a(amc) == h.a) && c5x.t.b != null)
					{
						List<ak1> list = c5x.t.b.af();
						if (list != null && list.Count != 0 && list.Contains(ak))
						{
							bd9 bd = Enumerable.First<bd9>(d4n.b.aa().StatusEffects.Get<bd9>());
							if (bd != null)
							{
								bd.b = A_0.Area.Zone.ElapsedZoneTime;
							}
							c5x c5x2 = (c5x)A_0;
							bt4 a_ = new bt4(c5x2.Area.y8(), c5x2.Location);
							c5x c5x3 = vq.a("Objects\\Natural\\IceChip", c5x2.Zone, a_, false);
							if (c5x3 != null)
							{
								c5x3.Size = new Vector3(1f, 1f, 0.1f);
								c5x3.Location = c5x2.aj() - c5x3.Size / 2f;
								c5x3.Size = new Vector3(0.2f, 0.2f, 0.1f);
								c5x3.ah();
							}
							c5x2.h();
							Vector3 vector = c5x.aj() + new Vector3(0f, 0f, c5x.Size.Z / 2f);
							Vector3 value = c5x3.aj();
							int num2 = (int)((value - vector).Length() / 0.2f);
							Vector3 value2 = (value - vector) / (float)num2;
							c5x.c().a("Cryokinesis");
							for (int i = 0; i < num2; i++)
							{
								Vector3 a_2 = vector + value2 * (float)i;
								c5x c5x4 = boj.a(c5x3.Area, a_2, null, "xphw_icedust", 1, double.MaxValue, null, null, null, null);
								if (c5x4 != null && c5x4.o.b != null)
								{
									c5x4.o.b.b = new Point(0, cuo.a.Next(4));
								}
							}
							bpr bpr = this.b.ao().aa() as bpr;
							if (bpr != null)
							{
								bpu bpu = new bpu(c5x3);
								bpu.a(bpr.l().e());
								bpu.b(bpr.l().d());
								c5x3.SetAspect<bpu>(bpu);
								mj mj = new mj(c5x3, bpu);
								c5x3.SetAspect<mj>(mj);
								qy qy = new qy();
								qy.b(false);
								qy.c(false);
								c5x c5x5 = null;
								ak1 ak2 = c5x3.Area.a(bpr.f().a());
								if (ak2 != null)
								{
									c5x5 = (Enumerable.FirstOrDefault<b0b>(ak2.Entities) as c5x);
								}
								c5x a_3 = null;
								ak1 ak3 = c5x3.Area.a(c5x3.aj().a());
								if (ak3 != null)
								{
									a_3 = (Enumerable.FirstOrDefault<b0b>(ak3.Entities) as c5x);
								}
								qy.ad().Add(new a4s(new bfq("CyrokinesisHit"), null, new ar7(a_3), null));
								List<auv> list2 = qy.ad();
								aud a_4 = c5x3.Area;
								Vector3 a_5 = c5x3.Location;
								string a_6 = "ColdHit";
								int a_7 = 1;
								double maxValue = double.MaxValue;
								float? a_8 = dz6.b();
								list2.Add(new au0(a_4, a_5, a_6, a_7, maxValue, null, null, a_8));
								qy.ad().Add(new bpr(mj, bpr.f()));
								List<auv> list3 = qy.ad();
								aud a_9 = c5x3.Area;
								Vector3 a_10 = bpr.f();
								string a_11 = "IceChipImpact";
								int a_12 = 1;
								double maxValue2 = double.MaxValue;
								a_8 = dz6.b();
								list3.Add(new au0(a_9, a_10, a_11, a_12, maxValue2, null, null, a_8));
								if (c5x5 != null)
								{
									qy.ad().Add(new a4s(new bfq("IceHit"), null, new ar7(c5x5), null));
								}
								qy.ad().Add(new c7(c5x3, false, false, true, false));
								qy.ad().Add(new eae("XPHWGJTC-GrenadeFreeze", null, null, null));
								c5x3.Zone.ActionManager.g9(qy, atp.a);
								dz6.a(qy);
								ap9 a_13 = null;
								if (this.c != null && this.c.ao() != null)
								{
									a_13 = new ap9(this.c.ao().aa());
								}
								vr a_14 = new vr(a_13, null, "{0}: Граната была перехвачена.", null, null);
								bey.a(a_14, (this.c != null && this.c.ao() != null) ? this.c.ao().aa() : null, (this.c != null) ? this.c.ao() : null);
								a7v.a(a_14);
							}
							this.b.ao().j();
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x04003193 RID: 12691
	private float a;

	// Token: 0x04003194 RID: 12692
	public ActionReference<qy> b;

	// Token: 0x04003195 RID: 12693
	public EntityAspectReference<amc, amc> c;
}
