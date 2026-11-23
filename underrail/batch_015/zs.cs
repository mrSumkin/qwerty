using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001264 RID: 4708
[eiz("BEA78")]
[a(typeof(ce1))]
[Serializable]
public sealed class zs : ce1, ISerializable
{
	// Token: 0x060065FD RID: 26109 RVA: 0x002B62E4 File Offset: 0x002B44E4
	private zs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("BEA78:B");
	}

	// Token: 0x060065FE RID: 26110 RVA: 0x002B6300 File Offset: 0x002B4500
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BEA78:B", this.a);
	}

	// Token: 0x060065FF RID: 26111 RVA: 0x002B631C File Offset: 0x002B451C
	public zs(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006600 RID: 26112 RVA: 0x002B6328 File Offset: 0x002B4528
	public override void n3(int A_0)
	{
		if (!this.a && base.a8().o.b != null)
		{
			this.a = true;
			if (base.a8().o.b.a.EndsWith("_Withered", StringComparison.OrdinalIgnoreCase))
			{
				base.a8().o.b.a = base.a8().o.b.a.Substring(0, base.a8().o.b.a.Length - "_Withered".Length);
			}
			cd0 b = base.a8().o.b;
			b.a += "_Burned";
			base.a8().RemoveAspect<d8r>();
			if (cuo.a.NextDouble() < 0.35)
			{
				string text = "Effects\\";
				if (cuo.a.NextDouble() < 0.25)
				{
					text += "CitySmokeX";
				}
				else
				{
					text += "CitySmokeXS";
				}
				c5x c5x = vq.a(text, base.a8().Zone, new bt4(base.a8().Area.y8(), base.a8().Location + new Vector3(0.5f, 0f, 0.3f)), false);
				if (c5x != null)
				{
					etz etz = c5x.o.b as etz;
					if (etz != null)
					{
						etz.a(true);
					}
					int a_ = (int)(120000.0 * (0.75 + 0.5 * cuo.a.NextDouble()));
					cm aspect = new cm(c5x, a_, false);
					c5x.SetAspect<cm>(aspect);
				}
			}
		}
	}

	// Token: 0x04002A63 RID: 10851
	private bool a;
}
