using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010DA RID: 4314
[eiz("YD")]
[Serializable]
public sealed class e7r : cze, ISerializable
{
	// Token: 0x06005AEA RID: 23274 RVA: 0x00272748 File Offset: 0x00270948
	private e7r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("YD:I", typeof(Guid?));
		this.b = A_0.GetString("YD:A");
	}

	// Token: 0x06005AEB RID: 23275 RVA: 0x00272784 File Offset: 0x00270984
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("YD:I", this.a);
		info.AddValue("YD:A", this.b);
	}

	// Token: 0x06005AEC RID: 23276 RVA: 0x002727B8 File Offset: 0x002709B8
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005AED RID: 23277 RVA: 0x002727C0 File Offset: 0x002709C0
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005AEE RID: 23278 RVA: 0x002727CC File Offset: 0x002709CC
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06005AEF RID: 23279 RVA: 0x002727D4 File Offset: 0x002709D4
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005AF0 RID: 23280 RVA: 0x002727E0 File Offset: 0x002709E0
	public e7r()
	{
	}

	// Token: 0x06005AF1 RID: 23281 RVA: 0x002727EC File Offset: 0x002709EC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				aud = A_1.Zone.n(this.b);
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.a.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			cij aspect = c5x.GetAspect<cij>();
			if (aspect != null)
			{
				aspect.i();
			}
		}
	}

	// Token: 0x0400245B RID: 9307
	private new Guid? a;

	// Token: 0x0400245C RID: 9308
	private string b;
}
