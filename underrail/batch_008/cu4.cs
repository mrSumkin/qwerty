using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common;

// Token: 0x02001116 RID: 4374
[eiz("SDJ")]
[Serializable]
public sealed class cu4 : cze, ISerializable
{
	// Token: 0x06005D2E RID: 23854 RVA: 0x0027AE60 File Offset: 0x00279060
	private cu4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("SDJ:DI", typeof(Guid?)) as Guid?);
		this.b = (A_0.GetValue("SDJ:DIF", typeof(IFunction<object, Guid>)) as IFunction<object, Guid>);
		this.c = A_0.GetString("SDJ:CD");
	}

	// Token: 0x06005D2F RID: 23855 RVA: 0x0027AECC File Offset: 0x002790CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SDJ:DI", this.a);
		info.AddValue("SDJ:DIF", this.b);
		info.AddValue("SDJ:CD", this.c);
	}

	// Token: 0x06005D30 RID: 23856 RVA: 0x0027AF1C File Offset: 0x0027911C
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06005D31 RID: 23857 RVA: 0x0027AF24 File Offset: 0x00279124
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D32 RID: 23858 RVA: 0x0027AF30 File Offset: 0x00279130
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005D33 RID: 23859 RVA: 0x0027AF38 File Offset: 0x00279138
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005D34 RID: 23860 RVA: 0x0027AF44 File Offset: 0x00279144
	public cu4()
	{
	}

	// Token: 0x06005D35 RID: 23861 RVA: 0x0027AF50 File Offset: 0x00279150
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null || serviceOrThrow.aqu().v() == null)
		{
			return;
		}
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (c5x == null || c5x.Area == null || c5x.Zone == null)
		{
			return;
		}
		Guid a_;
		if (this.a != null)
		{
			a_ = this.a.Value;
		}
		else if (this.b != null)
		{
			a_ = this.b.a(this);
		}
		else
		{
			a_ = aju.a;
		}
		c5x c5x2 = c5x.Area.a(a_) as c5x;
		if (c5x2 != null)
		{
			if (c5x.i != null)
			{
				c5x.i.b.a(m7.e, true, false);
			}
			c9m a_2 = new c9m(c5x2.GetAspect<j7>(), c5x.GetAspect<j7>(), true, this.c, false);
			c5x.Zone.ActionManager.g9(a_2, atp.a);
		}
	}

	// Token: 0x04002526 RID: 9510
	private new Guid? a;

	// Token: 0x04002527 RID: 9511
	private IFunction<object, Guid> b;

	// Token: 0x04002528 RID: 9512
	private string c;
}
