using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020012F3 RID: 4851
[a(typeof(cd0))]
[eiz("CAEA")]
[Serializable]
public sealed class acx : cd0, bp1, ISerializable
{
	// Token: 0x06006BDB RID: 27611 RVA: 0x002D493C File Offset: 0x002D2B3C
	private acx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<etz>("CAEA:CO", ref this.a, A_0);
	}

	// Token: 0x06006BDC RID: 27612 RVA: 0x002D4964 File Offset: 0x002D2B64
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<etz>("CAEA:CO", this.a, info);
	}

	// Token: 0x06006BDD RID: 27613 RVA: 0x002D4980 File Offset: 0x002D2B80
	public acx(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006BDE RID: 27614 RVA: 0x002D4994 File Offset: 0x002D2B94
	public override Point oc(bool A_0)
	{
		if (this.b != 0)
		{
			int num = (int)base.a8().Zone.ElapsedZoneTime.TotalMilliseconds % this.b;
			int num2 = 0;
			int? a_ = null;
			for (int i = this.a.Count - 1; i >= 0; i--)
			{
				if (num >= this.c[i])
				{
					num2 = i;
					a_ = new int?(num - this.c[i]);
					break;
				}
			}
			if (A_0 && this.a.Count > num2)
			{
				return this.a[num2].a(A_0, a_);
			}
			if (this.a.Count > 0)
			{
				return new Point(this.a[0].d(), this.b.Y);
			}
		}
		return Point.Zero;
	}

	// Token: 0x06006BDF RID: 27615 RVA: 0x002D4A84 File Offset: 0x002D2C84
	public void mx()
	{
		this.b = 0;
		if (this.a.Count > 0)
		{
			this.c = new int[this.a.Count];
			this.c[0] = 0;
			for (int i = 0; i < this.a.Count; i++)
			{
				int num = this.a[i].b();
				this.b += num;
				if (i < this.a.Count - 1)
				{
					this.c[i + 1] = this.c[i] + num;
				}
			}
		}
	}

	// Token: 0x06006BE0 RID: 27616 RVA: 0x002D4B2C File Offset: 0x002D2D2C
	public void my()
	{
	}

	// Token: 0x04002C45 RID: 11333
	public new List<etz> a = new List<etz>();

	// Token: 0x04002C46 RID: 11334
	private new int b;

	// Token: 0x04002C47 RID: 11335
	private new int[] c;

	// Token: 0x04002C48 RID: 11336
	private new static Random d = new Random();
}
