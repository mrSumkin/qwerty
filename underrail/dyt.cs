using System;
using System.Runtime.Serialization;

// Token: 0x02000FBA RID: 4026
[eiz("CAGL")]
[Serializable]
public sealed class dyt : dnh, ISerializable
{
	// Token: 0x0600527D RID: 21117 RVA: 0x0024DEA4 File Offset: 0x0024C0A4
	private dyt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("CAGL:I", typeof(Guid?));
		this.b = A_0.GetString("CAGL:A");
		this.c = A_0.GetBoolean("CAGL:N");
		this.d = A_0.GetString("CAGL:S");
	}

	// Token: 0x0600527E RID: 21118 RVA: 0x0024DF0C File Offset: 0x0024C10C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CAGL:I", this.a);
		info.AddValue("CAGL:A", this.b);
		info.AddValue("CAGL:N", this.c);
		info.AddValue("CAGL:S", this.d);
	}

	// Token: 0x0600527F RID: 21119 RVA: 0x0024DF6C File Offset: 0x0024C16C
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005280 RID: 21120 RVA: 0x0024DF74 File Offset: 0x0024C174
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005281 RID: 21121 RVA: 0x0024DF80 File Offset: 0x0024C180
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x06005282 RID: 21122 RVA: 0x0024DF88 File Offset: 0x0024C188
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005283 RID: 21123 RVA: 0x0024DF94 File Offset: 0x0024C194
	public bool d()
	{
		return this.c;
	}

	// Token: 0x06005284 RID: 21124 RVA: 0x0024DF9C File Offset: 0x0024C19C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005285 RID: 21125 RVA: 0x0024DFA8 File Offset: 0x0024C1A8
	public string b()
	{
		return this.d;
	}

	// Token: 0x06005286 RID: 21126 RVA: 0x0024DFB0 File Offset: 0x0024C1B0
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005287 RID: 21127 RVA: 0x0024DFBC File Offset: 0x0024C1BC
	public dyt()
	{
	}

	// Token: 0x06005288 RID: 21128 RVA: 0x0024DFC8 File Offset: 0x0024C1C8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			b0b b0b = null;
			if (this.a != null && !string.IsNullOrEmpty(this.b))
			{
				aud aud = serviceOrThrow.aqw().n(this.b);
				if (aud != null)
				{
					b0b = new ar7(this.a.Value, aud).ao();
				}
			}
			else
			{
				b0b = (A_0.GetPropertyValue(c49.b) as b0b);
			}
			if (b0b != null)
			{
				bm6 aspect = b0b.GetAspect<bm6>();
				if (aspect != null)
				{
					bt4 classPropertyValue = aspect.y6().GetClassPropertyValue<bt4>(ddq.ay);
					if (classPropertyValue == null)
					{
						flag = string.IsNullOrEmpty(this.d);
					}
					else
					{
						flag = string.Equals(classPropertyValue.b(), this.d);
					}
				}
			}
		}
		return flag ^ this.c;
	}

	// Token: 0x040021CB RID: 8651
	private Guid? a;

	// Token: 0x040021CC RID: 8652
	private string b;

	// Token: 0x040021CD RID: 8653
	private bool c;

	// Token: 0x040021CE RID: 8654
	private string d;
}
