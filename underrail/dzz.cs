using System;
using System.Runtime.Serialization;

// Token: 0x02001C01 RID: 7169
[eiz("CCC")]
[Serializable]
public abstract class dzz : ISerializable
{
	// Token: 0x06009C00 RID: 39936 RVA: 0x003D3CB8 File Offset: 0x003D1EB8
	protected dzz(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (efk)A_0.GetValue("CCC:C", typeof(efk));
			return;
		}
		if (base.GetType() == typeof(dzz))
		{
			this.a = (efk)A_0.GetValue("_Character", typeof(efk));
			return;
		}
		this.a = (efk)A_0.GetValue("CharacterCombatComponent+_Character", typeof(efk));
	}

	// Token: 0x06009C01 RID: 39937 RVA: 0x003D3D54 File Offset: 0x003D1F54
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CCC:C", this.a);
	}

	// Token: 0x06009C02 RID: 39938 RVA: 0x003D3D68 File Offset: 0x003D1F68
	public efk a1()
	{
		return this.a;
	}

	// Token: 0x06009C03 RID: 39939 RVA: 0x003D3D70 File Offset: 0x003D1F70
	public void a(efk A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009C04 RID: 39940 RVA: 0x003D3D7C File Offset: 0x003D1F7C
	protected dzz(efk A_0)
	{
		czh.a(A_0, "character");
		this.a = A_0;
	}

	// Token: 0x04003C5D RID: 15453
	private efk a;
}
