using System;
using System.Runtime.Serialization;

// Token: 0x02001A62 RID: 6754
[eiz("AAM")]
[Serializable]
public sealed class dlp : bns, ISerializable
{
	// Token: 0x060092A5 RID: 37541 RVA: 0x0039FD90 File Offset: 0x0039DF90
	private dlp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060092A6 RID: 37542 RVA: 0x0039FD9C File Offset: 0x0039DF9C
	public dlp()
	{
	}

	// Token: 0x060092A7 RID: 37543 RVA: 0x0039FDA4 File Offset: 0x0039DFA4
	public override string h0(cd1 A_0)
	{
		if (A_0 != null && euf.j(A_0))
		{
			return "До ударный: Ракеты активируются до столкновения с поверхностью, что предотвращает их падение в воду и т.п.";
		}
		return "До ударный: Гранаты активируются до столкновения с поверхностью, что предотвращает их падение в воду и т.п.";
	}

	// Token: 0x060092A8 RID: 37544 RVA: 0x0039FDC8 File Offset: 0x0039DFC8
	public override bns h1()
	{
		dlp dlp = new dlp();
		this.h2(dlp);
		return dlp;
	}
}
