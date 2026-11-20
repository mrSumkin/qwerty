using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02001301 RID: 4865
[eiz("RGEA")]
[Serializable]
public sealed class e3l : Aspect<c5x>, bp1, ISerializable, bz2
{
	// Token: 0x06006C8D RID: 27789 RVA: 0x002D77E0 File Offset: 0x002D59E0
	private e3l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("RGEA:C", typeof(List<string>)) as List<string>);
	}

	// Token: 0x06006C8E RID: 27790 RVA: 0x002D7818 File Offset: 0x002D5A18
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RGEA:C", this.a);
	}

	// Token: 0x06006C8F RID: 27791 RVA: 0x002D7834 File Offset: 0x002D5A34
	public Guid b()
	{
		return this.b;
	}

	// Token: 0x06006C90 RID: 27792 RVA: 0x002D783C File Offset: 0x002D5A3C
	public e3l(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006C91 RID: 27793 RVA: 0x002D7850 File Offset: 0x002D5A50
	public void mx()
	{
		if (base.a8().Zone != null)
		{
			d60 addon = base.a8().Zone.GetAddon<d60>();
			if (addon != null)
			{
				this.b = addon.ab0(base.a8(), this.a);
			}
		}
	}

	// Token: 0x06006C92 RID: 27794 RVA: 0x002D789C File Offset: 0x002D5A9C
	public void my()
	{
		if (base.a8().Zone != null)
		{
			d60 addon = base.a8().Zone.GetAddon<d60>();
			if (addon != null)
			{
				addon.ab9(this.b, this.a);
			}
		}
	}

	// Token: 0x06006C93 RID: 27795 RVA: 0x002D78E4 File Offset: 0x002D5AE4
	public void a()
	{
		if (base.a8() != null && base.a8().Zone != null)
		{
			d60 addon = base.a8().Zone.GetAddon<d60>();
			if (addon != null)
			{
				addon.ab8(this.b);
				this.b = addon.ab0(base.a8(), this.a);
			}
		}
	}

	// Token: 0x06006C94 RID: 27796 RVA: 0x002D7948 File Offset: 0x002D5B48
	public KeyValuePair<string, Color>[] avu()
	{
		KeyValuePair<string, Color>[] array = new KeyValuePair<string, Color>[this.a.Count];
		for (int i = 0; i < this.a.Count; i++)
		{
			array[i] = new KeyValuePair<string, Color>(this.a[i], Color.White);
		}
		return array;
	}

	// Token: 0x04002C89 RID: 11401
	public List<string> a = new List<string>();

	// Token: 0x04002C8A RID: 11402
	[NonSerialized]
	private Guid b;
}
