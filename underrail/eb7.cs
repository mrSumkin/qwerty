using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001114 RID: 4372
[eiz("S12")]
[Serializable]
public sealed class eb7 : cze
{
	// Token: 0x06005D1E RID: 23838 RVA: 0x0027A978 File Offset: 0x00278B78
	private eb7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("S12:I", typeof(Guid?)) as Guid?);
		this.b = A_0.GetBoolean("S12:S");
	}

	// Token: 0x06005D1F RID: 23839 RVA: 0x0027A9B8 File Offset: 0x00278BB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S12:I", this.a);
		info.AddValue("S12:S", this.b);
	}

	// Token: 0x06005D20 RID: 23840 RVA: 0x0027A9EC File Offset: 0x00278BEC
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06005D21 RID: 23841 RVA: 0x0027A9F4 File Offset: 0x00278BF4
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D22 RID: 23842 RVA: 0x0027AA00 File Offset: 0x00278C00
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06005D23 RID: 23843 RVA: 0x0027AA08 File Offset: 0x00278C08
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005D24 RID: 23844 RVA: 0x0027AA14 File Offset: 0x00278C14
	public eb7()
	{
	}

	// Token: 0x06005D25 RID: 23845 RVA: 0x0027AA1C File Offset: 0x00278C1C
	public eb7(Guid? A_0, bool A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06005D26 RID: 23846 RVA: 0x0027AA34 File Offset: 0x00278C34
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a != null)
		{
			aud aud = (A_0 != null) ? A_0.Area : null;
			if (aud == null)
			{
				aud = ((A_1 != null) ? A_1.Area : null);
			}
			if (aud != null)
			{
				ar7 ar = new ar7(this.a.Value, aud);
				if (ar.ao() != null)
				{
					axh aspect = ar.ao().GetAspect<axh>();
					if (aspect != null)
					{
						aspect.a(A_0 as c5x, this.b, null);
					}
				}
			}
		}
	}

	// Token: 0x04002523 RID: 9507
	private new Guid? a;

	// Token: 0x04002524 RID: 9508
	private bool b;
}
