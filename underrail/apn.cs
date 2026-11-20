using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001081 RID: 4225
[eiz("SHRJ")]
[Serializable]
public sealed class apn : cze
{
	// Token: 0x0600580B RID: 22539 RVA: 0x002641FC File Offset: 0x002623FC
	private apn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("SHRJ:E", ref this.a, A_0);
		this.b = A_0.GetBoolean("SHRJ:T");
	}

	// Token: 0x0600580C RID: 22540 RVA: 0x0026423C File Offset: 0x0026243C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("SHRJ:E", this.a, info);
		info.AddValue("SHRJ:T", this.b);
	}

	// Token: 0x0600580D RID: 22541 RVA: 0x00264268 File Offset: 0x00262468
	public List<Guid> a()
	{
		return this.a;
	}

	// Token: 0x0600580E RID: 22542 RVA: 0x00264270 File Offset: 0x00262470
	public void a(List<Guid> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600580F RID: 22543 RVA: 0x0026427C File Offset: 0x0026247C
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06005810 RID: 22544 RVA: 0x00264284 File Offset: 0x00262484
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005811 RID: 22545 RVA: 0x00264290 File Offset: 0x00262490
	public apn()
	{
	}

	// Token: 0x06005812 RID: 22546 RVA: 0x002642AC File Offset: 0x002624AC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			if (this.b && A_1 != null)
			{
				this.a(aud, A_1.qe());
			}
			foreach (Guid a_ in this.a)
			{
				this.a(aud, a_);
			}
		}
	}

	// Token: 0x06005813 RID: 22547 RVA: 0x0026434C File Offset: 0x0026254C
	private void a(aud A_0, Guid A_1)
	{
		c5x c5x = new ar7(A_1, A_0).ao() as c5x;
		if (c5x != null)
		{
			cya aspect = c5x.GetAspect<cya>();
			if (aspect != null)
			{
				aspect.p();
			}
		}
	}

	// Token: 0x0400238B RID: 9099
	private new List<Guid> a = new List<Guid>();

	// Token: 0x0400238C RID: 9100
	private bool b = true;
}
