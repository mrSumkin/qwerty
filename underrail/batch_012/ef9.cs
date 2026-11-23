using System;
using System.Runtime.Serialization;

// Token: 0x0200127C RID: 4732
[eiz("UWBEA")]
[a(typeof(ce1))]
[Serializable]
public sealed class ef9 : ce1, ISerializable
{
	// Token: 0x060066CE RID: 26318 RVA: 0x002BAB68 File Offset: 0x002B8D68
	private ef9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 556)
		{
			this.a = A_0.GetBoolean("UWBEA:T");
			return;
		}
		this.a = true;
	}

	// Token: 0x060066CF RID: 26319 RVA: 0x002BABA4 File Offset: 0x002B8DA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UWBEA:T", this.a);
	}

	// Token: 0x060066D0 RID: 26320 RVA: 0x002BABC0 File Offset: 0x002B8DC0
	public ef9(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060066D1 RID: 26321 RVA: 0x002BABD4 File Offset: 0x002B8DD4
	public override void n3(int A_0)
	{
		if (this.a)
		{
			foreach (cn7 cn in base.a8().Aspects)
			{
				bwt bwt = cn as bwt;
				if (bwt != null)
				{
					ya ya = bwt.av8();
					if (ya != null)
					{
						ya.o();
					}
				}
			}
		}
		c7 a_ = new c7(base.a8(), false, false, false, false);
		base.a8().Zone.ActionManager.g9(a_, atp.a);
		dz6.a(a_);
	}

	// Token: 0x04002AA4 RID: 10916
	public bool a = true;
}
