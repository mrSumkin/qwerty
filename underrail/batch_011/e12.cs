using System;
using System.Runtime.Serialization;

// Token: 0x02001966 RID: 6502
[eiz("GPST0")]
[Serializable]
public sealed class e12 : wq, ISerializable
{
	// Token: 0x06008B18 RID: 35608 RVA: 0x0038E928 File Offset: 0x0038CB28
	private e12(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("GPST0:S");
	}

	// Token: 0x06008B19 RID: 35609 RVA: 0x0038E944 File Offset: 0x0038CB44
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GPST0:S", this.a);
	}

	// Token: 0x06008B1A RID: 35610 RVA: 0x0038E960 File Offset: 0x0038CB60
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008B1B RID: 35611 RVA: 0x0038E968 File Offset: 0x0038CB68
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008B1C RID: 35612 RVA: 0x0038E974 File Offset: 0x0038CB74
	public override string avs()
	{
		return "GrantPsionicTransceiver_Tick";
	}

	// Token: 0x06008B1D RID: 35613 RVA: 0x0038E97C File Offset: 0x0038CB7C
	public e12()
	{
	}

	// Token: 0x06008B1E RID: 35614 RVA: 0x0038E984 File Offset: 0x0038CB84
	public override void dk(ll A_0, int A_1)
	{
	}

	// Token: 0x06008B1F RID: 35615 RVA: 0x0038E988 File Offset: 0x0038CB88
	public override void dl(ll A_0, int A_1)
	{
	}

	// Token: 0x06008B20 RID: 35616 RVA: 0x0038E98C File Offset: 0x0038CB8C
	public override string ToString()
	{
		return string.Format("Даёт {0} бонус ко всем псионическим навыкам и каждому другому псионику, находящемуся поблизости.", ck3.a * this.a);
	}

	// Token: 0x06008B21 RID: 35617 RVA: 0x0038E9AC File Offset: 0x0038CBAC
	public override wq dn()
	{
		e12 e = new e12();
		this.@do(e);
		return e;
	}

	// Token: 0x06008B22 RID: 35618 RVA: 0x0038E9C8 File Offset: 0x0038CBC8
	protected override void @do(wq A_0)
	{
		base.@do(A_0);
		e12 e = A_0 as e12;
		if (e != null)
		{
			e.a = this.a;
		}
	}

	// Token: 0x0400378B RID: 14219
	private int a;
}
