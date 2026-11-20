using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;

// Token: 0x0200130A RID: 4874
[eiz("RCGEA")]
[Serializable]
public sealed class ew1 : Aspect<c5x>, bp1, ISerializable
{
	// Token: 0x06006D1F RID: 27935 RVA: 0x002D9E7C File Offset: 0x002D807C
	private ew1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetBoolean("RCGEA:RD");
			this.b = (a6b)A_0.GetValue("RCGEA:OS", typeof(a6b));
			return;
		}
		this.a = A_0.GetBoolean("_RandomDirection");
		this.b = (A_0.GetValue("_OpportunitySet", typeof(a6b)) as a6b);
	}

	// Token: 0x06006D20 RID: 27936 RVA: 0x002D9F0C File Offset: 0x002D810C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RCGEA:RD", this.a);
		info.AddValue("RCGEA:OS", this.b);
	}

	// Token: 0x06006D21 RID: 27937 RVA: 0x002D9F38 File Offset: 0x002D8138
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06006D22 RID: 27938 RVA: 0x002D9F40 File Offset: 0x002D8140
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006D23 RID: 27939 RVA: 0x002D9F4C File Offset: 0x002D814C
	public a6b a()
	{
		return this.b;
	}

	// Token: 0x06006D24 RID: 27940 RVA: 0x002D9F54 File Offset: 0x002D8154
	public void a(a6b A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006D25 RID: 27941 RVA: 0x002D9F60 File Offset: 0x002D8160
	public ew1(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006D26 RID: 27942 RVA: 0x002D9F78 File Offset: 0x002D8178
	public bool d()
	{
		bool result = false;
		if (this.b != null && base.a8().Area != null)
		{
			b0b b0b = bgq.a(this.b);
			if (b0b != null)
			{
				if (this.a)
				{
					b0b.VisualDirection = (HorizontalDirection)zp.a.Next(8);
				}
				else
				{
					b0b.VisualDirection = base.a8().VisualDirection;
				}
				b0b.Location = base.a8().Location;
				b0b.Layer = aju.x;
				base.a8().Area.a(b0b);
				result = true;
			}
		}
		base.a8().an();
		return result;
	}

	// Token: 0x06006D27 RID: 27943 RVA: 0x002DA024 File Offset: 0x002D8224
	public void mx()
	{
		base.a8().g |= e2b.g;
	}

	// Token: 0x06006D28 RID: 27944 RVA: 0x002DA03C File Offset: 0x002D823C
	public void my()
	{
		base.a8().g &= ~e2b.g;
	}

	// Token: 0x04002CB5 RID: 11445
	private bool a;

	// Token: 0x04002CB6 RID: 11446
	private a6b b = new a6b();
}
