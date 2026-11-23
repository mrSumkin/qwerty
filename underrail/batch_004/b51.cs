using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200101F RID: 4127
[eiz("SCSMS")]
[Serializable]
public sealed class b51 : cze, ISerializable
{
	// Token: 0x06005520 RID: 21792 RVA: 0x0025A578 File Offset: 0x00258778
	private b51(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (Guid?)A_0.GetValue("SCSMS:I", typeof(Guid?));
		this.d = A_0.GetString("SCSMS:A");
		this.a = A_0.GetBoolean("SCSMS:S");
		this.b = (bool?)A_0.GetValue("SCSMS:AS", typeof(bool?));
	}

	// Token: 0x06005521 RID: 21793 RVA: 0x0025A5F0 File Offset: 0x002587F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCSMS:I", this.c);
		info.AddValue("SCSMS:A", this.d);
		info.AddValue("SCSMS:S", this.a);
		info.AddValue("SCSMS:AS", this.b);
	}

	// Token: 0x06005522 RID: 21794 RVA: 0x0025A654 File Offset: 0x00258854
	public bool d()
	{
		return this.a;
	}

	// Token: 0x06005523 RID: 21795 RVA: 0x0025A65C File Offset: 0x0025885C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005524 RID: 21796 RVA: 0x0025A668 File Offset: 0x00258868
	public bool? c()
	{
		return this.b;
	}

	// Token: 0x06005525 RID: 21797 RVA: 0x0025A670 File Offset: 0x00258870
	public void a(bool? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005526 RID: 21798 RVA: 0x0025A67C File Offset: 0x0025887C
	public string a()
	{
		return this.d;
	}

	// Token: 0x06005527 RID: 21799 RVA: 0x0025A684 File Offset: 0x00258884
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005528 RID: 21800 RVA: 0x0025A690 File Offset: 0x00258890
	public Guid? b()
	{
		return this.c;
	}

	// Token: 0x06005529 RID: 21801 RVA: 0x0025A698 File Offset: 0x00258898
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600552A RID: 21802 RVA: 0x0025A6A4 File Offset: 0x002588A4
	public b51()
	{
	}

	// Token: 0x0600552B RID: 21803 RVA: 0x0025A6B0 File Offset: 0x002588B0
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.c != null)
		{
			aud aud = cze.a(this.d, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (new ar7(this.c.Value, aud).ao() as c5x);
			}
		}
		else if (A_1 != null)
		{
			c5x = (A_1 as c5x);
		}
		else
		{
			c5x = (A_0 as c5x);
		}
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().SpecialAbilities.a(typeof(e5b)))
		{
			if (this.b != null && c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.ba] = this.b;
			}
			if (this.d())
			{
				new aty(ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(c5x.h.b)), null) as bl6, c5x, new bool?(false));
				return;
			}
			c5x.h.b.u();
		}
	}

	// Token: 0x040022B5 RID: 8885
	private new bool a;

	// Token: 0x040022B6 RID: 8886
	private bool? b;

	// Token: 0x040022B7 RID: 8887
	private Guid? c;

	// Token: 0x040022B8 RID: 8888
	private string d;
}
