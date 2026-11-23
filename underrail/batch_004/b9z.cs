using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001493 RID: 5267
[eiz("UCA")]
[Serializable]
public sealed class b9z : pl, ISerializable
{
	// Token: 0x060076B0 RID: 30384 RVA: 0x00323BE8 File Offset: 0x00321DE8
	private b9z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(b9z);
		}
	}

	// Token: 0x060076B1 RID: 30385 RVA: 0x00323C14 File Offset: 0x00321E14
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060076B2 RID: 30386 RVA: 0x00323C20 File Offset: 0x00321E20
	public override CharacterState? m3()
	{
		return new CharacterState?(CharacterState.Operating);
	}

	// Token: 0x060076B3 RID: 30387 RVA: 0x00323C28 File Offset: 0x00321E28
	public b9z(ad5 A_0) : base(A_0)
	{
	}

	// Token: 0x060076B4 RID: 30388 RVA: 0x00323C34 File Offset: 0x00321E34
	protected override int ade()
	{
		return dz6.b(cux.a);
	}
}
