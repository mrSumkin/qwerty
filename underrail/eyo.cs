using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012B8 RID: 4792
[eiz("POEA")]
[Serializable]
public sealed class eyo : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x06006995 RID: 27029 RVA: 0x002C878C File Offset: 0x002C698C
	private eyo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<cze>("POEA:J", ref this.a, A_0);
		this.b = A_0.GetBoolean("POEA:O");
		this.c = (A_0.GetValue("POEA:D", typeof(double?)) as double?);
		this.d = (A_0.GetValue("POEA:C", typeof(dth)) as dth);
	}

	// Token: 0x06006996 RID: 27030 RVA: 0x002C8814 File Offset: 0x002C6A14
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("POEA:J", this.a, info);
		info.AddValue("POEA:O", this.b);
		info.AddValue("POEA:D", this.c);
		info.AddValue("POEA:C", this.d);
	}

	// Token: 0x06006997 RID: 27031 RVA: 0x002C8874 File Offset: 0x002C6A74
	public List<cze> d()
	{
		return this.a;
	}

	// Token: 0x06006998 RID: 27032 RVA: 0x002C887C File Offset: 0x002C6A7C
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006999 RID: 27033 RVA: 0x002C8888 File Offset: 0x002C6A88
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600699A RID: 27034 RVA: 0x002C8890 File Offset: 0x002C6A90
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600699B RID: 27035 RVA: 0x002C889C File Offset: 0x002C6A9C
	public double? a()
	{
		return this.c;
	}

	// Token: 0x0600699C RID: 27036 RVA: 0x002C88A4 File Offset: 0x002C6AA4
	public void a(double? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600699D RID: 27037 RVA: 0x002C88B0 File Offset: 0x002C6AB0
	public dth e()
	{
		return this.d;
	}

	// Token: 0x0600699E RID: 27038 RVA: 0x002C88B8 File Offset: 0x002C6AB8
	public void a(dth A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600699F RID: 27039 RVA: 0x002C88C4 File Offset: 0x002C6AC4
	public eyo(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060069A0 RID: 27040 RVA: 0x002C88DC File Offset: 0x002C6ADC
	public void r7(eds A_0)
	{
		if (!this.b && base.a8() != null && base.a8().j == cgy.b && base.a8().Area != null && base.a8().c(dm9.b))
		{
			bool flag = false;
			if (this.c != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null && serviceOrThrow.aqu().v().b().Area == base.a8().Area && aw1.b(serviceOrThrow.aqu().v().b(), base.a8()) <= this.c.Value)
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (flag && (this.d == null || this.d.jh(base.a8())))
			{
				foreach (cze cze in this.a)
				{
					cze.ym(null, base.a8(), new Dictionary<string, object>());
				}
				this.b = true;
			}
		}
	}

	// Token: 0x060069A1 RID: 27041 RVA: 0x002C8A74 File Offset: 0x002C6C74
	public void f()
	{
		this.b = false;
	}

	// Token: 0x04002B7F RID: 11135
	private List<cze> a = new List<cze>();

	// Token: 0x04002B80 RID: 11136
	private bool b;

	// Token: 0x04002B81 RID: 11137
	private double? c;

	// Token: 0x04002B82 RID: 11138
	private dth d;
}
