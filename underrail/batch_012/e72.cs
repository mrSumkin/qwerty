using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x020004EE RID: 1262
[eiz("PRIA")]
[Serializable]
public sealed class e72 : esc, ISerializable
{
	// Token: 0x0600209A RID: 8346 RVA: 0x000B0288 File Offset: 0x000AE488
	private e72(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x000B0294 File Offset: 0x000AE494
	public override int d5(bq8 A_0, bq8 A_1)
	{
		foreach (string text in Enumerable.ToList<string>(Enumerable.Select<Property, string>(A_1.get_Properties(), new Func<Property, string>(e72.a.a.a))))
		{
			if (text.StartsWith("__rumorInt_"))
			{
				A_1.RemoveProperty(text);
			}
		}
		return 0;
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x000B032C File Offset: 0x000AE52C
	public e72()
	{
	}

	// Token: 0x020004EF RID: 1263
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600209F RID: 8351 RVA: 0x000B0348 File Offset: 0x000AE548
		internal string a(Property A_0)
		{
			return A_0.Name;
		}

		// Token: 0x0400141E RID: 5150
		public static readonly e72.a a = new e72.a();

		// Token: 0x0400141F RID: 5151
		public static Func<Property, string> b;
	}
}
