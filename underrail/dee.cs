using System;
using System.Runtime.Serialization;

// Token: 0x02001985 RID: 6533
[eiz("RRHE")]
[dn2("rapidReload")]
[Serializable]
public sealed class dee : buu, ISerializable
{
	// Token: 0x06008BBA RID: 35770 RVA: 0x0038FE10 File Offset: 0x0038E010
	private dee(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BBB RID: 35771 RVA: 0x0038FE20 File Offset: 0x0038E020
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс восстановить {1} - {2} очков действия. Может произойти только один раз за ход.", (int)(A_0.Chance * 100.0), A_0.Power / 2, A_0.Power);
		}
		return string.Format("Восстанавливает {0} - {1} очков действия. Может произойти только один раз за ход.", A_0.Power / 2, A_0.Power);
	}

	// Token: 0x06008BBC RID: 35772 RVA: 0x0038FE9C File Offset: 0x0038E09C
	public override bool yk(edm A_0)
	{
		return true;
	}

	// Token: 0x06008BBD RID: 35773 RVA: 0x0038FEA0 File Offset: 0x0038E0A0
	public dee()
	{
	}
}
