using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001632 RID: 5682
[eiz("PCTA")]
[Serializable]
public sealed class c34 : boa, ISerializable
{
	// Token: 0x06007CCD RID: 31949 RVA: 0x0034B4BC File Offset: 0x003496BC
	private c34(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 614)
		{
			this.a = (A_0.GetValue("PCTA:I", typeof(CharacterState?)) as CharacterState?);
		}
	}

	// Token: 0x06007CCE RID: 31950 RVA: 0x0034B4FC File Offset: 0x003496FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PCTA:I", this.a);
	}

	// Token: 0x06007CCF RID: 31951 RVA: 0x0034B51C File Offset: 0x0034971C
	public override CharacterState? q1()
	{
		if (this.a != null)
		{
			return new CharacterState?(this.a.Value);
		}
		return new CharacterState?(CharacterState.ChannelPsi);
	}

	// Token: 0x06007CD0 RID: 31952 RVA: 0x0034B548 File Offset: 0x00349748
	public c34(ad5 A_0, afq A_1, params evd[] A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06007CD1 RID: 31953 RVA: 0x0034B554 File Offset: 0x00349754
	public c34(ad5 A_0, CharacterState A_1, afq A_2, params evd[] A_3) : base(A_0, A_2, A_3)
	{
		this.a = new CharacterState?(A_1);
	}

	// Token: 0x04003191 RID: 12689
	private new CharacterState? a;
}
