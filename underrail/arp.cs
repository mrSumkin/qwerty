using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Rules;

// Token: 0x02000ACE RID: 2766
[eiz("XPHWTWAJ")]
[Serializable]
public sealed class arp : cze, ISerializable
{
	// Token: 0x06004082 RID: 16514 RVA: 0x00188B3C File Offset: 0x00186D3C
	private arp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("XPHWTWAJ:P");
	}

	// Token: 0x06004083 RID: 16515 RVA: 0x00188B58 File Offset: 0x00186D58
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWTWAJ:P", this.a);
	}

	// Token: 0x06004084 RID: 16516 RVA: 0x00188B74 File Offset: 0x00186D74
	public string a()
	{
		return this.a;
	}

	// Token: 0x06004085 RID: 16517 RVA: 0x00188B7C File Offset: 0x00186D7C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004086 RID: 16518 RVA: 0x00188B88 File Offset: 0x00186D88
	public arp()
	{
	}

	// Token: 0x06004087 RID: 16519 RVA: 0x00188B94 File Offset: 0x00186D94
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					this.a
				})) as c5x;
				if (c5x != null && !c5x.a("disabled"))
				{
					dm aspect = c5x.GetAspect<dm>();
					if (aspect != null)
					{
						if (serviceOrThrow.aqu().ae() <= GameDifficulty.Normal)
						{
							aspect.a(new int?(20000));
						}
						else if (serviceOrThrow.aqu().ae() == GameDifficulty.Hard)
						{
							aspect.a(new int?(15000));
						}
						else if (serviceOrThrow.aqu().ae() == GameDifficulty.Dominating)
						{
							aspect.a(new int?(10000));
						}
						aspect.b(true);
						dm dm = aspect;
						int? num = aspect.e();
						dm.a(new int?((int)((num != null) ? new float?((float)num.GetValueOrDefault() * 1f) : null).Value));
					}
					ah7 ah = c5x.Zone.i(c5x.qe().ToString() + "_trainingLantern");
					bfq bfq = new bfq();
					bfq.a(bvl.d);
					bfq.c("FleshStab2");
					bfq.ym(c5x, c5x, null);
					if (ah == null)
					{
						ah = new ah7(c5x.qe().ToString() + "_trainingLantern", c5x.Zone);
						ah.Layer = c5x.Layer;
						ah.Light = new ae8(dyz.k, 1f, LightType.Increment);
						ah.LightFadeRate = 0.21f;
						ah.Range = 5f;
						c5x.Zone.a(ah);
						ah.g().be(c5x);
						alv aspect2 = c5x.GetAspect<alv>();
						if (aspect2 != null && aspect2.a[1] != null)
						{
							aspect2.a[1].c = new Color?(dyz.k);
						}
					}
					ah.d();
					Enumerable.FirstOrDefault<cze>(aspect.d()).ym(A_0, A_1, A_2);
					ya ya = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(serviceOrThrow.aqw().Areas[0].Triggers, new Func<ya, bool>(this.a)));
					if (ya != null)
					{
						ya.o();
					}
				}
			}
		}
	}

	// Token: 0x06004088 RID: 16520 RVA: 0x00188E30 File Offset: 0x00187030
	[CompilerGenerated]
	private bool a(ya A_0)
	{
		return A_0.Name == this.a;
	}

	// Token: 0x04001BFF RID: 7167
	private new string a;
}
