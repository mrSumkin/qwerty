using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001459 RID: 5209
[eiz("GTIA")]
[Serializable]
public sealed class b2s : ad5, ISerializable
{
	// Token: 0x0600753E RID: 30014 RVA: 0x0031ADC8 File Offset: 0x00318FC8
	private b2s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600753F RID: 30015 RVA: 0x0031ADD4 File Offset: 0x00318FD4
	protected override m7 d6()
	{
		return m7.a;
	}

	// Token: 0x06007540 RID: 30016 RVA: 0x0031ADD8 File Offset: 0x00318FD8
	public b2s(eu7 A_0, c5x A_1, object A_2) : base(A_0, A_1, A_2, false)
	{
	}

	// Token: 0x06007541 RID: 30017 RVA: 0x0031ADE4 File Offset: 0x00318FE4
	public override pl d7()
	{
		return new dre(this);
	}

	// Token: 0x06007542 RID: 30018 RVA: 0x0031ADEC File Offset: 0x00318FEC
	public override boa d8(afq A_0, params evd[] A_1)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06007543 RID: 30019 RVA: 0x0031ADF4 File Offset: 0x00318FF4
	public override b1z oq(dqw A_0)
	{
		int num;
		int num2;
		base.a(CharacterState.Throw, out num, out num2);
		return new e4t(base.q().h.b, CharacterState.Throw, dz6.b(cux.i), 0, new int?(num - 1), 1);
	}

	// Token: 0x06007544 RID: 30020 RVA: 0x0031AE38 File Offset: 0x00319038
	public override List<cst> ea(dqw A_0)
	{
		int a_;
		int num;
		base.a(CharacterState.Throw, out a_, out num);
		return new List<cst>
		{
			new e4t(base.q().h.b, CharacterState.Throw, dz6.b(cux.i), a_, null, 1)
		};
	}

	// Token: 0x06007545 RID: 30021 RVA: 0x0031AE88 File Offset: 0x00319088
	protected override c47 eb()
	{
		ap9 a_ = null;
		ap9 a_2 = new ap9(base.e().b8());
		string str = "{1} готовит бросок: ";
		object obj = base.e().b9();
		return new vr(a_, a_2, str + ((obj != null) ? obj.ToString() : null) + "...", null, null);
	}

	// Token: 0x06007546 RID: 30022 RVA: 0x0031AEE4 File Offset: 0x003190E4
	protected override c47 ec()
	{
		ap9 a_ = null;
		ap9 a_2 = new ap9(base.e().b8());
		string str = "{1} метает: ";
		object obj = base.e().b9();
		return new vr(a_, a_2, str + ((obj != null) ? obj.ToString() : null) + ".", null, null);
	}
}
