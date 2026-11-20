using System;
using System.Runtime.Serialization;

// Token: 0x0200132F RID: 4911
[eiz("PSNA")]
[Serializable]
public sealed class b8p : b1z, ISerializable
{
	// Token: 0x06006F3C RID: 28476 RVA: 0x002EB358 File Offset: 0x002E9558
	private b8p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("PSNA:SR", typeof(ar7));
			this.b = (c3r)A_0.GetValue("PSNA:N", typeof(c3r));
			return;
		}
		if (base.GetType() == typeof(b8p))
		{
			this.a = (ar7)A_0.GetValue("_SourceRef", typeof(ar7));
			this.b = (c3r)A_0.GetValue("_Notification", typeof(c3r));
			return;
		}
		this.a = (ar7)A_0.GetValue("PublishScrollingNotificationAction+_SourceRef", typeof(ar7));
		this.b = (c3r)A_0.GetValue("PublishScrollingNotificationAction+_Notification", typeof(c3r));
	}

	// Token: 0x06006F3D RID: 28477 RVA: 0x002EB454 File Offset: 0x002E9654
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PSNA:SR", this.a);
		info.AddValue("PSNA:N", this.b);
	}

	// Token: 0x06006F3E RID: 28478 RVA: 0x002EB480 File Offset: 0x002E9680
	public b8p(ar7 A_0, c3r A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06006F3F RID: 28479 RVA: 0x002EB498 File Offset: 0x002E9698
	public b8p(b0b A_0, c3r A_1) : this(new ar7(A_0), A_1)
	{
	}

	// Token: 0x06006F40 RID: 28480 RVA: 0x002EB4A8 File Offset: 0x002E96A8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b != null && this.a != null && this.a.ao() != null)
		{
			bmj.a(this.a.ao(), this.b);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002D7C RID: 11644
	private new ar7 a;

	// Token: 0x04002D7D RID: 11645
	private c3r b;
}
