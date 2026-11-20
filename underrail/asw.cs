using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001265 RID: 4709
[a(typeof(ce1))]
[eiz("BMREA")]
[Serializable]
public sealed class asw : ce1, ISerializable
{
	// Token: 0x06006601 RID: 26113 RVA: 0x002B6508 File Offset: 0x002B4708
	private asw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("BMREA:B");
	}

	// Token: 0x06006602 RID: 26114 RVA: 0x002B6524 File Offset: 0x002B4724
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BMREA:B", this.a);
	}

	// Token: 0x06006603 RID: 26115 RVA: 0x002B6540 File Offset: 0x002B4740
	public asw(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006604 RID: 26116 RVA: 0x002B654C File Offset: 0x002B474C
	public override void n3(int A_0)
	{
		if (!this.a && base.a8().o.b != null)
		{
			this.a = true;
			if (base.a8().o.b.a.EndsWith("_Withered", StringComparison.OrdinalIgnoreCase))
			{
				base.a8().o.b.a = base.a8().o.b.a.Substring(0, base.a8().o.b.a.Length - "_Withered".Length);
			}
			base.a8().TileFormationModifiers.s4(1);
			base.a8().z();
			base.a8().IsGround = true;
			base.a8().ah();
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

	// Token: 0x04002A64 RID: 10852
	private bool a;
}
