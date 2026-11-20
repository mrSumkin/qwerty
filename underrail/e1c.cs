using System;
using System.Runtime.Serialization;

// Token: 0x02001A0F RID: 6671
[eiz("SHFE")]
[Serializable]
public sealed class e1c : dts, ISerializable
{
	// Token: 0x0600901F RID: 36895 RVA: 0x00399864 File Offset: 0x00397A64
	private e1c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009020 RID: 36896 RVA: 0x00399870 File Offset: 0x00397A70
	public e1c()
	{
	}

	// Token: 0x06009021 RID: 36897 RVA: 0x00399878 File Offset: 0x00397A78
	public e1c(int A_0) : base(A_0)
	{
	}

	// Token: 0x06009022 RID: 36898 RVA: 0x00399884 File Offset: 0x00397A84
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			A_0.a().Defense.e(base.c());
		}
	}

	// Token: 0x06009023 RID: 36899 RVA: 0x003998B8 File Offset: 0x00397AB8
	public override string b2()
	{
		return string.Format("Здоровье установлено в {0}", base.c());
	}

	// Token: 0x06009024 RID: 36900 RVA: 0x003998D0 File Offset: 0x00397AD0
	public override d3e b3()
	{
		e1c e1c = new e1c();
		this.xx(e1c);
		return e1c;
	}
}
