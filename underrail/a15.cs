using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x02000B37 RID: 2871
[eiz("SOFSPJ")]
[Serializable]
public sealed class a15 : cze, ISerializable
{
	// Token: 0x06004218 RID: 16920 RVA: 0x00199998 File Offset: 0x00197B98
	private a15(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<string>("SOFSPJ:SL", ref this.a, A_0);
			if (ell.a() >= 10)
			{
				this.b = (A_0.GetValue("SOFSPJ:WL", typeof(List<Guid>)) as List<Guid>);
				return;
			}
			this.b = new List<Guid>();
			return;
		}
		else
		{
			if (base.GetType() == typeof(a15))
			{
				this.a = (List<string>)A_0.GetValue("_StationLanterns", typeof(List<string>));
				return;
			}
			this.a = (List<string>)A_0.GetValue("SwitchOnForlornStationPowerJob+_StationLanterns", typeof(List<string>));
			return;
		}
	}

	// Token: 0x06004219 RID: 16921 RVA: 0x00199A74 File Offset: 0x00197C74
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("SOFSPJ:SL", this.a, info);
		info.AddValue("SOFSPJ:WL", this.b);
	}

	// Token: 0x0600421A RID: 16922 RVA: 0x00199AA0 File Offset: 0x00197CA0
	public List<Guid> b()
	{
		return this.b;
	}

	// Token: 0x0600421B RID: 16923 RVA: 0x00199AA8 File Offset: 0x00197CA8
	public List<string> a()
	{
		return this.a;
	}

	// Token: 0x0600421C RID: 16924 RVA: 0x00199AB0 File Offset: 0x00197CB0
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600421D RID: 16925 RVA: 0x00199ABC File Offset: 0x00197CBC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x == null || c5x.Area == null || c5x.o.b == null)
		{
			return;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bq8 bq = serviceOrThrow.aqu().e();
		int? primitivePropertyValue = bq.GetPrimitivePropertyValue<int>(bp5.h("retakingOldOutposts"), null);
		dtb dtb = new dtb();
		dtb.ad().Add(new ben(c5x.o.b, new Point(1, 0)));
		if (primitivePropertyValue != null && primitivePropertyValue.Value >= 3)
		{
			int? num = bq.GetPrimitivePropertyValue<int>(bp5.c("retakingOldOutposts", "ActivatedOutposts"), null);
			if (num != null)
			{
				num++;
			}
			else
			{
				num = new int?(1);
			}
			bq.set_Item(bp5.c("retakingOldOutposts", "ActivatedOutposts"), num.Value);
			c5x.RemoveAspect<bim>();
			if (this.a != null)
			{
				foreach (string text in this.a)
				{
					if (!string.IsNullOrEmpty(text))
					{
						ah7 ah = c5x.Zone.i(text);
						ah.Enabled = true;
						ah.d();
					}
				}
			}
			if (this.b != null)
			{
				foreach (Guid a_ in this.b)
				{
					c5x c5x2 = new ar7(a_, c5x.Area).ao() as c5x;
					if (c5x2 != null)
					{
						alv alv = c5x2.p.b;
						if (alv != null && alv.a.Count > 1)
						{
							alv.a[1].d = new float?(0.9f);
							alv.a[1].c = new Color?(new Color(255, 255, 128));
						}
						c5x c5x3 = c5x2;
						a3f aspect = c5x3.GetAspect<a3f>();
						if (aspect != null && aspect.a() != null)
						{
							Guid? primitivePropertyValue2 = aspect.a().GetPrimitivePropertyValue<Guid>("proxy", null);
							if (primitivePropertyValue2 != null)
							{
								c5x3 = ((new ar7(primitivePropertyValue2.Value, c5x2.Area).ao() as c5x) ?? c5x2);
							}
						}
						ah7 ah2 = new ah7("WallLantern" + c5x2.qe().ToString(), c5x.Zone);
						ah2.Light = new ae8(Color.White, 1f, LightType.Increment);
						ah2.LightFadeRate = 0.15f;
						ah2.Range = 6f;
						ah2.Layer = c5x2.Layer;
						c5x.Zone.a(ah2);
						ah2.g().be(c5x3);
						if (c5x3.i.b == null)
						{
							c5x3.SetAspect<ny>(new ny(c5x2));
						}
					}
				}
			}
			if (A_2 != null && A_2.ContainsKey("activateElevator"))
			{
				object obj = A_2.ContainsKey("activateElevator");
				if (obj is bool && (bool)obj)
				{
					serviceOrThrow.aqu().r()[bp5.c("retakingOldOutposts", "ActivatedElevator")] = true;
					c5x c5x4 = new ar7(new Guid("41a873e0-4c70-42f6-90ae-32c48f77754f"), c5x.Area).ao() as c5x;
					if (c5x4 != null)
					{
						c5x4.GetAspect<axh>().a(A_0 as c5x, true, null);
					}
				}
			}
			aru aru = c5x.v.b;
			if (aru != null)
			{
				aru.a("switch", false);
				aru.a("switch", "LeverSwitchPull", 1f, c9z.a, false, false);
			}
			a7v.a(new h0(qv.b("Narration\\Prolog/forlornStationPowerRestored"), null));
		}
		else
		{
			dtb.ad().Add(new bm3(200));
			dtb.ad().Add(new ben(c5x.o.b, new Point(0, 0)));
			aru aru2 = c5x.v.b;
			if (aru2 != null)
			{
				aru2.a("switch", false);
				aru2.a("switch", "LeverSwitchPullAndSnapBack", 1f, c9z.a, false, false);
			}
			a7v.a(new h0(qv.b("Narration\\Prolog/forlornStationPowerSwitchSnapBack"), null));
		}
		c5x.Zone.ActionManager.g9(dtb, atp.a);
	}

	// Token: 0x04001C1F RID: 7199
	private new List<string> a = new List<string>();

	// Token: 0x04001C20 RID: 7200
	private List<Guid> b = new List<Guid>();
}
