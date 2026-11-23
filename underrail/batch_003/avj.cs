using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000AD6 RID: 2774
[eiz("XPBLKL3BAV")]
[Serializable]
public sealed class avj : cze, ISerializable
{
	// Token: 0x060040B1 RID: 16561 RVA: 0x00189FE4 File Offset: 0x001881E4
	private avj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("XPBLKL3BAV:D");
	}

	// Token: 0x060040B2 RID: 16562 RVA: 0x0018A000 File Offset: 0x00188200
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLKL3BAV:D", this.a);
	}

	// Token: 0x060040B3 RID: 16563 RVA: 0x0018A01C File Offset: 0x0018821C
	public avj()
	{
	}

	// Token: 0x060040B4 RID: 16564 RVA: 0x0018A024 File Offset: 0x00188224
	public string a()
	{
		return this.a;
	}

	// Token: 0x060040B5 RID: 16565 RVA: 0x0018A02C File Offset: 0x0018822C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060040B6 RID: 16566 RVA: 0x0018A038 File Offset: 0x00188238
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				int num = 0;
				int num2 = 0;
				string text = "";
				string text2 = "";
				string text3 = this.a;
				if (!(text3 == "N"))
				{
					if (!(text3 == "E"))
					{
						if (!(text3 == "W"))
						{
							if (text3 == "S")
							{
								num = 16;
								num2 = 27;
								text = "xpbl_kirillLab3_gasS";
								text2 = "xpbl_kirillLab3_pipeS";
							}
						}
						else
						{
							num = 5;
							num2 = 16;
							text = "xpbl_kirillLab3_gasW";
							text2 = "xpbl_kirillLab3_pipeW";
						}
					}
					else
					{
						num = 27;
						num2 = 16;
						text = "xpbl_kirillLab3_gasE";
						text2 = "xpbl_kirillLab3_pipeE";
					}
				}
				else
				{
					num = 16;
					num2 = 5;
					text = "xpbl_kirillLab3_gasN";
					text2 = "xpbl_kirillLab3_pipeN";
				}
				d60 d = c5x.Zone.a();
				if (d != null)
				{
					eir.d(c5x.Zone);
					a1q a_ = default(a1q);
					cwt cwt = new cwt();
					cwt.i = new ap9("Acid leak", c5x.h.b.aa().FactionId);
					cwt.l = true;
					cwt.v = "acid burn";
					cwt.b = true;
					cwt.e = false;
					cwt.w = false;
					cwt.ad["IsAcidWeapon"] = true;
					bool flag = false;
					cav cav = new cav();
					cav.a(cuo.a.Next(350, 550));
					cav.a(new int?(2));
					cav.d(new int?(2));
					cav.e(new int?(2));
					cav.c(new int?(2));
					cav.b(new int?(15));
					int num3 = 2;
					if (this.a.Equals("E") || this.a.Equals("W"))
					{
						num3 = 3;
					}
					d02 service = bpo.GetService<d02>();
					if (service != null)
					{
						foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
						{
							if (d4n != null && d4n.b.a8().Location.X >= (float)num && d4n.b.a8().Location.X <= (float)(num + 3) && d4n.b.a8().Location.Y >= (float)num2 && d4n.b.a8().Location.Y <= (float)(num2 + num3))
							{
								flag = true;
								a_ = new a1q(DamageType.Acid, (int)d4n.b.aa().Defense.q().zm() / 4, (int)d4n.b.aa().Defense.q().zm() / 3);
								cwt.f.Clear();
								cwt.f.Add(euf.a(a_, 1.0));
								d4n.b.aa().Defense.a(cwt);
							}
						}
					}
					List<b0b> list = d.ab4(new string[]
					{
						text
					});
					if (list != null)
					{
						foreach (b0b b0b in list)
						{
							((c5x)b0b).ae = new float?((float)1);
						}
					}
					list.Clear();
					list = d.ab4(new string[]
					{
						text2
					});
					if (list != null)
					{
						foreach (b0b b0b2 in list)
						{
							c5x c5x2 = (c5x)b0b2;
							if (this.a.Equals("E") || this.a.Equals("W"))
							{
								c5x2.o.b.b.X = 16;
							}
							else
							{
								c5x2.o.b.b.X = 18;
							}
						}
					}
					awx awx = new awx();
					awx awx2 = awx;
					awx2.a(awx2.kh() | m7.b);
					awx.ad().Add(new a4s(new bfq("ValveOperate"), null, new ar7(c5x), null));
					awx.ad().Add(new bm3(cuo.a.Next(50, 150)));
					awx.ad().Add(new a4s(cav, null, null, null));
					awx.ad().Add(new a4s(new bfq("BarrelSlam"), null, new ar7(c5x), null));
					awx.ad().Add(new bm3(cuo.a.Next(50, 150)));
					awx.ad().Add(new a4s(new bfq("BarrelCrash"), null, new ar7(c5x), null));
					awx.ad().Add(new bm3(cuo.a.Next(200, 400)));
					if (flag)
					{
						awx.ad().Add(new bm3(cuo.a.Next(100, 300)));
						awx.ad().Add(new a4s(new bfq("AcidFizz"), null, new ar7(c5x), null));
						awx.ad().Add(new bm3(cuo.a.Next(200, 400)));
						awx.ad().Add(new a4s(new bfq("AcidBlobBigHit"), null, new ar7(c5x), null));
					}
					c5x.Zone.ActionManager.g9(awx, atp.a);
				}
			}
		}
	}

	// Token: 0x04001C05 RID: 7173
	private new string a;
}
