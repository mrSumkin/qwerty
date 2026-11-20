using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B68 RID: 2920
[eiz("WWSELS")]
[Serializable]
public sealed class al9 : cze, ISerializable
{
	// Token: 0x060042E3 RID: 17123 RVA: 0x001A1F6C File Offset: 0x001A016C
	private al9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("WWSELS:L");
	}

	// Token: 0x060042E4 RID: 17124 RVA: 0x001A1F88 File Offset: 0x001A0188
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WWSELS:L", this.a);
	}

	// Token: 0x060042E5 RID: 17125 RVA: 0x001A1FA4 File Offset: 0x001A01A4
	public bool a()
	{
		return this.a;
	}

	// Token: 0x060042E6 RID: 17126 RVA: 0x001A1FAC File Offset: 0x001A01AC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060042E7 RID: 17127 RVA: 0x001A1FB8 File Offset: 0x001A01B8
	public al9()
	{
	}

	// Token: 0x060042E8 RID: 17128 RVA: 0x001A1FC4 File Offset: 0x001A01C4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"electronicDoors"
				}))
				{
					c5x c5x = (c5x)b0b;
					cnb cnb = c5x.GetAspect<bim>() as cnb;
					if (cnb != null && !cnb.q())
					{
						d2b aspect = c5x.GetAspect<d2b>();
						if (aspect != null)
						{
							bool flag = false;
							if (this.a && !aspect.n())
							{
								aspect.e(true);
								a7v.a(new jj());
								bmj.a(c5x, new d53("Заперто", adi.h, null, false));
								if (cnb.b() != null)
								{
									flag = true;
								}
							}
							else if (!this.a && aspect.n())
							{
								aspect.e(false);
								a7v.a(new jj());
								bmj.a(c5x, new d53("Открыто", adi.h, null, false));
								if (cnb.b() != null)
								{
									flag = true;
								}
							}
							if (flag && new ar7(cnb.b().Value, c5x.Area).ao() is c5x)
							{
								d2b aspect2 = c5x.GetAspect<d2b>();
								if (aspect2 != null)
								{
									aspect2.e(this.a);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04001C31 RID: 7217
	private new bool a;
}
