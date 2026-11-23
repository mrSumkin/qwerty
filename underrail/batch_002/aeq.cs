using System;
using System.Runtime.Serialization;

// Token: 0x02000511 RID: 1297
[eiz("CE1")]
[Serializable]
public abstract class aeq : eyx, ISerializable
{
	// Token: 0x0600216D RID: 8557 RVA: 0x000B2940 File Offset: 0x000B0B40
	protected aeq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ap9)A_0.GetValue("CE1:S", typeof(ap9));
			return;
		}
		if (base.GetType() == typeof(aeq))
		{
			this.a = (ap9)A_0.GetValue("_Subject", typeof(ap9));
			return;
		}
		this.a = (ap9)A_0.GetValue("CharacterEvent+_Subject", typeof(ap9));
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x000B29DC File Offset: 0x000B0BDC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CE1:S", this.a);
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x000B29F8 File Offset: 0x000B0BF8
	public ap9 h()
	{
		return this.a;
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x000B2A00 File Offset: 0x000B0C00
	protected aeq(ap9 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x000B2A14 File Offset: 0x000B0C14
	public string i()
	{
		if (aji.a != null)
		{
			string text = qv.b("EntityNames/Someone");
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return "Нечто";
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x000B2A48 File Offset: 0x000B0C48
	public string g()
	{
		if (aji.a != null)
		{
			string text = qv.b("EntityNames/Something");
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return "Что-то";
	}

	// Token: 0x0400144D RID: 5197
	private ap9 a;
}
