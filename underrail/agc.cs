using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001633 RID: 5683
[eiz("PSIA")]
[Serializable]
public sealed class agc : ad5, ISerializable
{
	// Token: 0x06007CD2 RID: 31954 RVA: 0x0034B56C File Offset: 0x0034976C
	private agc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(agc);
		}
	}

	// Token: 0x06007CD3 RID: 31955 RVA: 0x0034B598 File Offset: 0x00349798
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06007CD4 RID: 31956 RVA: 0x0034B5A4 File Offset: 0x003497A4
	protected override m7 d6()
	{
		return m7.f;
	}

	// Token: 0x06007CD5 RID: 31957 RVA: 0x0034B5A8 File Offset: 0x003497A8
	public agc(eu7 A_0, c5x A_1, object A_2) : base(A_0, A_1, A_2, false)
	{
	}

	// Token: 0x06007CD6 RID: 31958 RVA: 0x0034B5B4 File Offset: 0x003497B4
	public override void op()
	{
		base.op();
		bd0 bd = base.e() as bd0;
		if (bd != null)
		{
			bd.b8().j((int)bd.a());
		}
	}

	// Token: 0x06007CD7 RID: 31959 RVA: 0x0034B5EC File Offset: 0x003497EC
	public override pl d7()
	{
		return new axs(this);
	}

	// Token: 0x06007CD8 RID: 31960 RVA: 0x0034B5F8 File Offset: 0x003497F8
	public override boa d8(afq A_0, params evd[] A_1)
	{
		a3b a3b = base.u();
		CharacterState a_;
		if (a3b != null && Enum.TryParse<CharacterState>(a3b.e, out a_))
		{
			return new c34(this, a_, A_0, A_1);
		}
		return new c34(this, A_0, A_1);
	}

	// Token: 0x06007CD9 RID: 31961 RVA: 0x0034B638 File Offset: 0x00349838
	public override b1z oq(dqw A_0)
	{
		a3b a3b = base.u();
		CharacterState characterState;
		if (a3b == null || !Enum.TryParse<CharacterState>(a3b.c, out characterState))
		{
			characterState = CharacterState.FinishPsi;
		}
		int num;
		int num2;
		base.a(characterState, out num, out num2);
		int a_;
		if (a3b != null && a3b.d != null)
		{
			a_ = dz6.b(a3b.d.Value);
		}
		else
		{
			a_ = base.a(characterState);
		}
		return new e4t(base.q().h.b, characterState, a_, 0, new int?(num - 1), 1);
	}

	// Token: 0x06007CDA RID: 31962 RVA: 0x0034B6CC File Offset: 0x003498CC
	public override List<cst> ea(dqw A_0)
	{
		a3b a3b = base.u();
		CharacterState characterState;
		if (a3b == null || !Enum.TryParse<CharacterState>(a3b.c, out characterState))
		{
			characterState = CharacterState.FinishPsi;
		}
		int a_;
		int num;
		base.a(characterState, out a_, out num);
		int a_2;
		if (a3b != null && a3b.d != null)
		{
			a_2 = dz6.b(a3b.d.Value);
		}
		else
		{
			a_2 = base.a(characterState);
		}
		return new List<cst>
		{
			new duh(base.q().h.b, new string[]
			{
				f9.a
			}),
			new e4t(base.q().h.b, characterState, a_2, a_, null, 1)
		};
	}

	// Token: 0x06007CDB RID: 31963 RVA: 0x0034B79C File Offset: 0x0034999C
	protected override c47 eb()
	{
		return new b6m(new ap9(base.e().b8()), base.e().p().Name, base.e().p().Nature);
	}

	// Token: 0x06007CDC RID: 31964 RVA: 0x0034B7E0 File Offset: 0x003499E0
	protected override c47 ec()
	{
		return new b9s(new ap9(base.e().b8()), base.e().p().Name, base.e().p().Nature);
	}
}
