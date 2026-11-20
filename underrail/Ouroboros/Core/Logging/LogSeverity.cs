using System;

namespace Ouroboros.Core.Logging
{
	// Token: 0x0200001A RID: 26
	[eiz("eLS")]
	[Serializable]
	public enum LogSeverity
	{
		// Token: 0x04000082 RID: 130
		Verbose,
		// Token: 0x04000083 RID: 131
		Information,
		// Token: 0x04000084 RID: 132
		Warning,
		// Token: 0x04000085 RID: 133
		Error,
		// Token: 0x04000086 RID: 134
		CriticalError,
		// Token: 0x04000087 RID: 135
		None = 999
	}
}
