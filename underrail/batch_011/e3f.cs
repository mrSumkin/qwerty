using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200123D RID: 4669
[eiz("P8")]
[Serializable]
public sealed class e3f : c3r, ISerializable
{
	// Token: 0x060064C1 RID: 25793 RVA: 0x002B2398 File Offset: 0x002B0598
	private e3f(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("P8:A");
	}

	// Token: 0x060064C2 RID: 25794 RVA: 0x002B23B4 File Offset: 0x002B05B4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("P8:A", this.a);
	}

	// Token: 0x060064C3 RID: 25795 RVA: 0x002B23C8 File Offset: 0x002B05C8
	public string sf()
	{
		return "Psi";
	}

	// Token: 0x060064C4 RID: 25796 RVA: 0x002B23D0 File Offset: 0x002B05D0
	public string sg()
	{
		return "+" + this.a.ToString();
	}

	// Token: 0x060064C5 RID: 25797 RVA: 0x002B23E8 File Offset: 0x002B05E8
	public Color sh()
	{
		return adi.z;
	}

	// Token: 0x060064C6 RID: 25798 RVA: 0x002B23F0 File Offset: 0x002B05F0
	public bool si()
	{
		return false;
	}

	// Token: 0x060064C7 RID: 25799 RVA: 0x002B23F4 File Offset: 0x002B05F4
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.PsiGain;
	}

	// Token: 0x060064C8 RID: 25800 RVA: 0x002B23F8 File Offset: 0x002B05F8
	public e3f(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04002A25 RID: 10789
	private int a;
}
