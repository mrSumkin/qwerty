using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200145E RID: 5214
[eiz("NSIA")]
[Serializable]
public sealed class bu4 : ad5, ISerializable
{
	// Token: 0x0600758C RID: 30092 RVA: 0x0031CCB0 File Offset: 0x0031AEB0
	private bu4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetBoolean("NSIA:PE");
			return;
		}
		if (base.GetType() == typeof(bu4))
		{
			this.a = A_0.GetBoolean("_PublishEvents");
			return;
		}
		this.a = A_0.GetBoolean("NeutralSpellInvocationAction+_PublishEvents");
	}

	// Token: 0x0600758D RID: 30093 RVA: 0x0031CD20 File Offset: 0x0031AF20
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NSIA:PE", this.a);
	}

	// Token: 0x0600758E RID: 30094 RVA: 0x0031CD3C File Offset: 0x0031AF3C
	protected override m7 d6()
	{
		return m7.a;
	}

	// Token: 0x0600758F RID: 30095 RVA: 0x0031CD40 File Offset: 0x0031AF40
	public bu4(eu7 A_0, c5x A_1, object A_2, bool A_3) : base(A_0, A_1, A_2, true)
	{
		this.a = A_3;
		base.r();
	}

	// Token: 0x06007590 RID: 30096 RVA: 0x0031CD5C File Offset: 0x0031AF5C
	public override pl d7()
	{
		a3b a3b = base.u();
		CharacterState characterState;
		if (a3b != null && Enum.TryParse<CharacterState>(a3b.a, out characterState))
		{
			int value;
			if (a3b.b != null)
			{
				value = a3b.b.Value;
			}
			else
			{
				value = base.a(characterState);
			}
			return new b3f(this, new CharacterState?(characterState), new int?(value));
		}
		return new b3f(this, null, null);
	}

	// Token: 0x06007591 RID: 30097 RVA: 0x0031CDE0 File Offset: 0x0031AFE0
	public override boa d8(afq A_0, params evd[] A_1)
	{
		a3b a3b = base.u();
		CharacterState value;
		if (a3b != null && Enum.TryParse<CharacterState>(a3b.e, out value))
		{
			return new c7c(this, new CharacterState?(value), A_0, A_1);
		}
		return new c7c(this, null, A_0, A_1);
	}

	// Token: 0x06007592 RID: 30098 RVA: 0x0031CE2C File Offset: 0x0031B02C
	protected override c47 eb()
	{
		if (this.a)
		{
			return new b5c(new ap9(base.e().b8()), base.e().p().Name, base.e().p().Nature);
		}
		return null;
	}

	// Token: 0x06007593 RID: 30099 RVA: 0x0031CE7C File Offset: 0x0031B07C
	protected override c47 ec()
	{
		if (this.a)
		{
			return new c1m(new ap9(base.e().b8()), base.e().p().Name, base.e().p().Nature);
		}
		return null;
	}

	// Token: 0x0400301C RID: 12316
	private new bool a;
}
