using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C76 RID: 3190
[eiz("LNCDLE")]
[Serializable]
public abstract class d4 : cd2
{
	// Token: 0x060047F2 RID: 18418 RVA: 0x001D8E70 File Offset: 0x001D7070
	protected d4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060047F3 RID: 18419 RVA: 0x001D8E7C File Offset: 0x001D707C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x060047F4 RID: 18420 RVA: 0x001D8E8C File Offset: 0x001D708C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x060047F5 RID: 18421 RVA: 0x001D8E9C File Offset: 0x001D709C
	public override bool ey()
	{
		return false;
	}

	// Token: 0x060047F6 RID: 18422 RVA: 0x001D8EA0 File Offset: 0x001D70A0
	protected d4()
	{
	}

	// Token: 0x060047F7 RID: 18423 RVA: 0x001D8EA8 File Offset: 0x001D70A8
	protected d4(string A_0) : base(A_0)
	{
	}

	// Token: 0x060047F8 RID: 18424 RVA: 0x001D8EB4 File Offset: 0x001D70B4
	protected override bool ez(cyt A_0)
	{
		if (A_0 == null || A_0.v() == null || A_0.v().Dead || A_0.v().b() == null || A_0.v().b().j != cgy.b)
		{
			return false;
		}
		string text = e3m.a();
		List<string> list = new List<string>
		{
			"D5",
			"D6",
			"E5",
			"E6"
		};
		return text != null && !list.Contains(text);
	}
}
