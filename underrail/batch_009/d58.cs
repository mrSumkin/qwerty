using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001975 RID: 6517
[eiz("PC11")]
[dn2("plasmaCut")]
[Serializable]
public sealed class d58 : buu, ISerializable
{
	// Token: 0x06008B7F RID: 35711 RVA: 0x0038F704 File Offset: 0x0038D904
	private d58(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B80 RID: 35712 RVA: 0x0038F710 File Offset: 0x0038D910
	public d58()
	{
	}

	// Token: 0x06008B81 RID: 35713 RVA: 0x0038F71C File Offset: 0x0038D91C
	public override string e1(edm A_0)
	{
		a1q[] array = d58.a(A_0);
		int num = d58.b(A_0);
		string format;
		if (A_0.Chance < 1.0)
		{
			format = "{0}% шанс нанести {1} и {2} урона цели. Затрачивает {3} энергии.";
		}
		else
		{
			format = "Наносит {1} и {2} урона цели. Затрачивает {3} энергии.";
		}
		return string.Format(format, new object[]
		{
			(int)(A_0.Chance * 100.0),
			array[0].a(true),
			array[1].a(true),
			num
		});
	}

	// Token: 0x06008B82 RID: 35714 RVA: 0x0038F7AC File Offset: 0x0038D9AC
	public static int b(edm A_0)
	{
		return A_0.Power / 7;
	}

	// Token: 0x06008B83 RID: 35715 RVA: 0x0038F7B8 File Offset: 0x0038D9B8
	public new static a1q[] a(edm A_0)
	{
		return new a1q[]
		{
			new a1q(DamageType.Energy, (int)(0.5 * (double)A_0.Power / 2.0), A_0.Power / 2),
			new a1q(DamageType.Heat, (int)(0.5 * (double)A_0.Power / 2.0), A_0.Power / 2)
		};
	}
}
