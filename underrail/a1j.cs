using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x0200107B RID: 4219
[eiz("SWTRJ")]
[Serializable]
public sealed class a1j : cze, ISerializable
{
	// Token: 0x060057F9 RID: 22521 RVA: 0x00263E70 File Offset: 0x00262070
	private a1j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060057FA RID: 22522 RVA: 0x00263E7C File Offset: 0x0026207C
	public a1j()
	{
	}

	// Token: 0x060057FB RID: 22523 RVA: 0x00263E88 File Offset: 0x00262088
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_1.RaysEmitters), new Func<bsf, bool>(a1j.a.a.a)));
		if (bsf != null)
		{
			bsf.ig();
		}
	}

	// Token: 0x0200107C RID: 4220
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060057FE RID: 22526 RVA: 0x00263EF0 File Offset: 0x002620F0
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "swampTranceLantern";
		}

		// Token: 0x04002387 RID: 9095
		public static readonly a1j.a a = new a1j.a();

		// Token: 0x04002388 RID: 9096
		public static Func<bsf, bool> b;
	}
}
