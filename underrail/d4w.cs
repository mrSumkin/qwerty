using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001027 RID: 4135
[eiz("RCRCJ")]
[Serializable]
public sealed class d4w : cze, ISerializable
{
	// Token: 0x06005554 RID: 21844 RVA: 0x0025B26C File Offset: 0x0025946C
	private d4w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("RCRCJ:I", typeof(Guid?));
		this.c = A_0.GetString("RCRCJ:A");
		this.a = A_0.GetString("RCRCJ:R");
		this.d = A_0.GetBoolean("RCRCJ:C");
	}

	// Token: 0x06005555 RID: 21845 RVA: 0x0025B2D4 File Offset: 0x002594D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RCRCJ:I", this.b);
		info.AddValue("RCRCJ:A", this.c);
		info.AddValue("RCRCJ:R", this.a);
		info.AddValue("RCRCJ:C", this.d);
	}

	// Token: 0x06005556 RID: 21846 RVA: 0x0025B334 File Offset: 0x00259534
	public string c()
	{
		return this.a;
	}

	// Token: 0x06005557 RID: 21847 RVA: 0x0025B33C File Offset: 0x0025953C
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005558 RID: 21848 RVA: 0x0025B348 File Offset: 0x00259548
	public string b()
	{
		return this.c;
	}

	// Token: 0x06005559 RID: 21849 RVA: 0x0025B350 File Offset: 0x00259550
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600555A RID: 21850 RVA: 0x0025B35C File Offset: 0x0025955C
	public Guid? d()
	{
		return this.b;
	}

	// Token: 0x0600555B RID: 21851 RVA: 0x0025B364 File Offset: 0x00259564
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600555C RID: 21852 RVA: 0x0025B370 File Offset: 0x00259570
	public bool a()
	{
		return this.d;
	}

	// Token: 0x0600555D RID: 21853 RVA: 0x0025B378 File Offset: 0x00259578
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600555E RID: 21854 RVA: 0x0025B384 File Offset: 0x00259584
	public d4w()
	{
	}

	// Token: 0x0600555F RID: 21855 RVA: 0x0025B390 File Offset: 0x00259590
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = cze.a(this.c, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (new ar7(this.b.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			e3l aspect = c5x.GetAspect<e3l>();
			if (aspect != null)
			{
				if (this.d)
				{
					c5x.RemoveAspect<e3l>();
					return;
				}
				aspect.a.Remove(this.a);
			}
		}
	}

	// Token: 0x040022C0 RID: 8896
	private new string a;

	// Token: 0x040022C1 RID: 8897
	private Guid? b;

	// Token: 0x040022C2 RID: 8898
	private string c;

	// Token: 0x040022C3 RID: 8899
	private bool d;
}
