import os

# Retrieve the API token from an environment variable.
# This avoids hardcoding secrets in the source code.
API_TOKEN = os.getenv("API_TOKEN")

if API_TOKEN is None:
    raise ValueError("API_TOKEN environment variable is not set. Please set it before running the application.")

def calculate_total(items):
    """Calculate the total sum of the provided items.

    Args:
        items (Iterable[Number]): An iterable of numeric values.

    Returns:
        Number: The sum of all items.
    """
    return sum(items)