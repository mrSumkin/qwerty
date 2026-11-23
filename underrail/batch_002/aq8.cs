using System;
using System.Runtime.Serialization;

// Token: 0x0200146C RID: 5228
[eiz("SIVA")]
[Serializable]
public sealed class aq8 : a6k, ISerializable
{
	// Token: 0x06007608 RID: 30216 RVA: 0x0031DB48 File Offset: 0x0031BD48
	private aq8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (evd)A_0.GetValue("SIVA:V", typeof(evd));
			this.b = (ad5)A_0.GetValue("SIVA:SI", typeof(ad5));
			this.c = (bool?)A_0.GetValue("SIVA:V1", typeof(bool?));
			return;
		}
		if (base.GetType() == typeof(aq8))
		{
			this.a = (evd)A_0.GetValue("_Validator", typeof(evd));
			this.b = (ad5)A_0.GetValue("_SpellInvocation", typeof(ad5));
			this.c = (bool?)A_0.GetValue("_Valid", typeof(bool?));
			return;
		}
		this.a = (evd)A_0.GetValue("SpellInvocationValidatorAction+_Validator", typeof(evd));
		this.b = (ad5)A_0.GetValue("SpellInvocationValidatorAction+_SpellInvocation", typeof(ad5));
		this.c = (bool?)A_0.GetValue("SpellInvocationValidatorAction+_Valid", typeof(bool?));
	}

	// Token: 0x06007609 RID: 30217 RVA: 0x0031DCA4 File Offset: 0x0031BEA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIVA:V", this.a);
		info.AddValue("SIVA:SI", this.b);
		info.AddValue("SIVA:V1", this.c);
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x0600760A RID: 30218 RVA: 0x0031DCF4 File Offset: 0x0031BEF4
	public evd Validator
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x0600760B RID: 30219 RVA: 0x0031DCFC File Offset: 0x0031BEFC
	public aq8(evd A_0, ad5 A_1)
	{
		czh.a(A_0, "validator");
		czh.a(A_1, "spellInvocation");
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600760C RID: 30220 RVA: 0x0031DD28 File Offset: 0x0031BF28
	protected override dc4 dt()
	{
		this.a.gm(new EventHandler<EventArgs>(this.a));
		this.a.go(this.b);
		return dc4.b;
	}

	// Token: 0x0600760D RID: 30221 RVA: 0x0031DD54 File Offset: 0x0031BF54
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null)
		{
			return dc4.e;
		}
		if (this.c == null)
		{
			return dc4.b;
		}
		if (!this.c.Value)
		{
			return dc4.e;
		}
		return dc4.c;
	}

	// Token: 0x0600760E RID: 30222 RVA: 0x0031DD88 File Offset: 0x0031BF88
	[dcc("SIVA:mOVV")]
	private void a(object A_0, EventArgs A_1)
	{
		this.c = (A_0 as evd).gl();
		this.a.gn(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x0400302D RID: 12333
	private new evd a;

	// Token: 0x0400302E RID: 12334
	private ad5 b;

	// Token: 0x0400302F RID: 12335
	private bool? c;
}
